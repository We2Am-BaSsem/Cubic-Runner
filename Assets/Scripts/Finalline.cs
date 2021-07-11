using UnityEngine;

public class Finalline : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<gamemanager>().completelevel();
    }
}
