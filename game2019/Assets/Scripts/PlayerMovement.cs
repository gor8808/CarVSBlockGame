using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 1500f;
	public float SidewaysForce = 60f;
	public Rigidbody Rb;

    void FixedUpdate()
    {
        Rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
    }
}
	