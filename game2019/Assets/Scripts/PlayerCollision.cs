using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement Movement;
    public Score ScoreData;
    public Rigidbody Rb;
    bool fall_ = false;

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Rb.position.y < 0.9f && !fall_)
        {
            Movement.enabled = false;
            ScoreData.enabled = false;
            fall_ = true;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    void OnCollisionEnter(Collision info)
	{
        
        if (info.collider.tag == "Obstacle")
		{
            Movement.enabled = false;
            ScoreData.enabled = false;
			FindObjectOfType<GameManager>().EndGame();	
		}
	}
        
    
}
