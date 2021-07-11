using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        if (player.position.y > 1.5f)
        {
            score.text = player.position.z.ToString("0");
        }
    }
}
