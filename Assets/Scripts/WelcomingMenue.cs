using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomingMenue : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
