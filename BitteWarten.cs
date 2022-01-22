using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BitteWarten : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ReturnToGame());
    }

    IEnumerator ReturnToGame()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
            SceneManager.LoadScene("Gameplay");
        }
    }
}
