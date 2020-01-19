using UnityEngine;
using UnityEngine.UI;

public class DifficultyTextChanger : MonoBehaviour
{
    public Text Difficulty;
    int _difficultyIndex = Menu.DifficultyIndex;
    void Start()
    {
        switch (_difficultyIndex)
        {
            case 0:
                Difficulty.text = "Easy";
                break;
            case 1:
                Difficulty.text = "Medium";
                break;
            case 2  :
                Difficulty.text = "Hard";
                break;
        }
    }
    
}
