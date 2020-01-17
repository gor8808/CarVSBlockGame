using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement Movement;
    public Score ScoreData;
    public RawImage DeadScore1;
    public RawImage DeadScore2;
    public RawImage DeadScore3;
    public Rigidbody Rb;
    bool fall_ = false;

    static int deadCount_ = 3;
    void Update()
    {
        if (deadCount_ == 3)
        {
            DeadScore1.gameObject.SetActive(false);
            DeadScore2.gameObject.SetActive(false);
            DeadScore3.gameObject.SetActive(true);
        }
        if (deadCount_ == 2)
        {
            DeadScore1.gameObject.SetActive(false);
            DeadScore2.gameObject.SetActive(true);
            DeadScore3.gameObject.SetActive(false);
        }
        if (deadCount_ == 1)
        {
            DeadScore1.gameObject.SetActive(true);
            DeadScore2.gameObject.SetActive(false);
            DeadScore3.gameObject.SetActive(false);
        }
        if (deadCount_ == 0)
        {
            DeadScore1.gameObject.SetActive(false);
            DeadScore2.gameObject.SetActive(false);
            DeadScore3.gameObject.SetActive(false);
            SceneManager.LoadScene(0);
            deadCount_ = 3;
        }
    }
    void FixedUpdate()
    {
        if (Rb.position.y < -1f && !fall_)
        {
            deadCount_ -= 1;
            Movement.enabled = false;
            ScoreData.enabled = false;
            //Debug.Log("Kpa");
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
			//Debug.Log("Kpa");
            Debug.Log(deadCount_);
			FindObjectOfType<GameManager>().EndGame();	
		}
	}
        
    
}
