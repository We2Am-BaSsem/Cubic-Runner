using UnityEngine;

public class playercollision : MonoBehaviour
{
    public Movement movement;

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            //Destroy(gameObject);
            FindObjectOfType<gamemanager>().GameOver();
        }
        if (collisioninfo.collider.tag == "FinalLine")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().completelevel();
        }
    }
}
