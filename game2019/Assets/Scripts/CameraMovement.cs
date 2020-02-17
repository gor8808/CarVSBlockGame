using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public Transform Player;
	public Vector3 Offset;
    void Update()
    {
		transform.position = Player.position + Offset;
    }
}

