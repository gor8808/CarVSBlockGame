using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded_ = false;
    public float RestartDelay = 1f;
    public GameObject CompleteLevelUI;
    public PlayerMovement Movement;

    int showCarIndex_ = Menu.ShowCarIndex;

    //public GameObject[] CarsArr;

    //void Start()
    //{ 
    //    CarsArr = GameObject.FindGameObjectsWithTag("Car");
    //    for (int i = 0; i < CarsArr.Length; i++)
    //    {
    //        if (i == showCarIndex_)
    //        {
    //            CarsArr[i].SetActive(true);
    //            continue;
    //        }
    //        CarsArr[i].SetActive(false);
    //    }
    //}
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        Movement.enabled = false;
        Debug.Log("LEVEL WON!!");
    }
	public void EndGame()
	{
		if(!gameHasEnded_)
		{
			gameHasEnded_ = true;
			Debug.Log("Game Over");
            //Restart();
            Invoke("Restart", RestartDelay);
		}

	}
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
