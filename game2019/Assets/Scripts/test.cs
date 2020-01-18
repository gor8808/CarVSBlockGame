using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform player;
    public Transform ground;
    public Vector3 offset;
    void Update()
    {
        ground.transform.position =
            new Vector3(
            ground.transform.position.x,
            ground.transform.position.y,
            player.transform.position.z - offset.z
            );
    }
}
