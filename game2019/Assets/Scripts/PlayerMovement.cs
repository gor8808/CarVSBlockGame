using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float MovementSpeed = 800f;
	public float SidewaysForce = 60f;
	public Rigidbody Rb;
    public GameObject Player;
    int _difficultyIndex = Menu.DifficultyIndex;
    float n = 10f;
    void FixedUpdate()
    {
        //Rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        //Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, n*Time.deltaTime);  
        //Player.transform.position = Player.transform.position + new Vector3(0,0, 50f * Time.deltaTime);
        switch (_difficultyIndex)
        {
            case 0:
                Player.transform.position = Player.transform.position + new Vector3(0, 0, 30f * Time.deltaTime);
                break;
            case 1:
                Player.transform.position = Player.transform.position + new Vector3(0, 0, 50f * Time.deltaTime);
                break;
            case 2:
                Rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
                break;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        n += n/200;
    }
}
	