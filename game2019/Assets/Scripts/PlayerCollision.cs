using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement Movement;
    public Score ScoreData;
    public Rigidbody Rb;
    bool fall_ = false;

    static int deadCount_ = 3;
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Rb.position.y < 0.9f && !fall_)
        {
            deadCount_ -= 1;
            Movement.enabled = false;
            ScoreData.enabled = false;
            Debug.Log(deadCount_);
            fall_ = true;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
    void OnCollisionEnter(Collision info)
	{
        
        if (info.collider.tag == "Obstacle")
		{
            deadCount_ -= 1;
            Movement.enabled = false;
            ScoreData.enabled = false;
            Debug.Log(deadCount_);
			FindObjectOfType<GameManager>().EndGame();	
		}
	}
        
    
}
