using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool GamehasEnded = false;
    static bool IsGamePaused = false;
    float restartdelay = 2f;
    public GameObject CompleteLevel;
    public GameObject Gameoverpanel;
    public GameObject pausemenue;
    public GameObject highscoreword;
    public GameObject score;
    public GameObject highscore;


    public void GameOver()
    {
        if(!GamehasEnded)
        {
           if(FindObjectOfType<HighScore>().gethighscorevalue() < float.Parse(FindObjectOfType<Score>().score.text))
            FindObjectOfType<HighScore>().sethighscorevalue(float.Parse(FindObjectOfType<Score>().score.text));
            GamehasEnded = true;
            Gameoverpanel.SetActive(true);
            Invoke("Restart", restartdelay);
        }
    }
  
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
                Resume();
            else
                pause();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GamehasEnded = false;
        Gameoverpanel.SetActive(false);
    }

    public void completelevel()
    {
        FindObjectOfType<HighScore>().sethighscorevalue(0f);
        CompleteLevel.SetActive(true);
    }

    public void Resume()
    {
        pausemenue.SetActive(false);
        highscoreword.SetActive(true);
        score.SetActive(true);
        highscore.SetActive(true);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }

    void pause()
    {
        pausemenue.SetActive(true);
        highscoreword.SetActive(false);
        score.SetActive(false);
        highscore.SetActive(false);
        Time.timeScale = 0f;
        IsGamePaused = true;
    }
}
