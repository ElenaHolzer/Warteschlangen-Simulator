using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUI : MonoBehaviour
{
    public void GoToOptions()
    {
        SceneManager.LoadScene("Optionen");
    }

    public void Restart()
    {
        SceneManager.LoadScene("BitteWarten");
    }
}
