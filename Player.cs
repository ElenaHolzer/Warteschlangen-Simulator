using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;

    public float speed = 5f;

    private float movementX;
    private string WALK_ANIMATION = "Walk";

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        transform.position = new Vector3(0, -3.65f, 0);
    }

    void Update()
    {
        FollowTouch();
        AnimatePlayer();
    }

    void FollowTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

                transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime * speed);
            }
        }
    }

    void AnimatePlayer()
    {
        movementX = Input.GetAxis("Horizontal");

        // walk to right side
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        // walk to left side
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        // idle (movementX = 0)
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
}

