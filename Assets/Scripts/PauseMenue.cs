using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenue : MonoBehaviour
{
    public void Resume()
    {
        FindObjectOfType<gamemanager>().Resume();
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<gamemanager>().Resume();
        FindObjectOfType<HighScore>().sethighscorevalue(0f);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
