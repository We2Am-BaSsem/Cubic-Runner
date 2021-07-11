using UnityEngine;

public class Follow_player : MonoBehaviour
{
    public Transform player_position;
    public Vector3 startoff;

    // Update is called once per frame
    void Update()
    {
        startoff.y = 1.2f;
        startoff.z = -7;
        transform.position = player_position.position + startoff;
    }
}
