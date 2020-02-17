using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Dropdown Difficulty;
    public Dropdown CarDropdown;
    public Text MuteButtonText;
    public static int ShowCarIndex = 0;
    public static int DifficultyIndex = 0;
    public static bool MusicIsMuted = false;
    //public Toggle Toggle;
    Material[] _material;
    GameObject[] _loadedCarsObjectArr;
    int randomNumber;
    void Start()
    {
        _loadedCarsObjectArr = Resources.LoadAll<GameObject>("MainPlayer");
        _material = Resources.LoadAll<Material>("PlayerMaterial");
        
    }
    void Update()
    {
        randomNumber = Random.Range(0, _loadedCarsObjectArr.Length);   
    }
    public void SetDifficulty()
    {
        DifficultyIndex = Difficulty.value;
        Debug.Log(DifficultyIndex);
    }
    public void StartGame()
    {
        ShowCarIndex = CarDropdown.value;
        SceneManager.LoadScene("level01");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OpenGAI()
    {
        Debug.Log("OpenGAI");
        Application.OpenURL("https://www.instagram.com/gai.project/");

    }
    public void MuteMusic()
    {
        if (MusicIsMuted)
        {
            AudioListener.volume = 1f;
            MusicIsMuted = false;
            MuteButtonText.text = "Mute Music";
        }
        else
        {
            MusicIsMuted = true;
            AudioListener.volume = 0f;
            MuteButtonText.text = "Play Music";
        }
    }
    public void SelectCar()
    {
        SceneManager.LoadScene("SelectCar");
    }
    public void SelectCarByRandom()
    {
        _material[0].color = RandomColor();
        ShowCarIndex = randomNumber;
        SceneManager.LoadScene("level01");
    }
    Color RandomColor()
        => new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

}
