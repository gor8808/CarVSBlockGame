using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseUI;
    public Text MuteButtonText;
    public static bool _gameIsPaused = false;
    bool _musicIsMuted = Menu.MusicIsMuted;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPaused)
                Resume();
            else
                Pause();
        }
        if (_musicIsMuted)
        {
            AudioListener.volume = 0f;
            MuteButtonText.text = "Play Music";
        }
        else
        {
            AudioListener.volume = 1f;
            MuteButtonText.text = "Mute Music";
        }
    }
    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }
    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Pause");
        _gameIsPaused = true;
    }
    public void MuteMusic()
    {
        if (_musicIsMuted)
        {
            AudioListener.volume = 0f;
            _musicIsMuted = false;
            MuteButtonText.text = "Play Music";
        }
        else
        {
            _musicIsMuted = true;
            AudioListener.volume = 1f;
            MuteButtonText.text = "Mute Music";
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;  
    }
    public void Manu()
    {
        SceneManager.LoadScene("Menu");
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }
}
