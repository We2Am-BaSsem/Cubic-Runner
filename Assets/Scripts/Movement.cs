using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public float pushingforce = 1500;
    public float sideforce = 20;

    // Update is called once per frame
    void FixedUpdate()
    {
        player.AddForce(0, 0, pushingforce * Time.deltaTime);

        if
            (Input.GetKey("d"))
        {
            player.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if
            (Input.GetKey("a"))
        {
            player.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (player.position.y < 1.5f)
        {
            FindObjectOfType<gamemanager>().GameOver();
        }
    }
}
