using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text highscore;
    public Text score;
    static float highscorevalue;

    void Start()
    {
        highscore.text = highscorevalue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (float.Parse(highscore.text) < float.Parse(score.text)) 
        highscore.text = score.text.ToString();
    }

    public void sethighscorevalue(float x)
    {
        highscorevalue = float.Parse(x.ToString());
    }

    public float gethighscorevalue()
    { 
        return highscorevalue;
    }
}
