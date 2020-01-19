using UnityEngine;
using UnityEngine.UI;

public class CameraMovementCarShow : MonoBehaviour
{
    public Text RotateByArrowsText; 
    public float speed = 20.0f;
    public bool AutoRotate = false;
    bool _musicIsMuted = Menu.MusicIsMuted;
    void Update()
    {
        if (_musicIsMuted)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
        if (Input.GetKey("r"))
        {
            AutoRotate = true;
        }
        if (Input.GetKey("n"))
        {
            AutoRotate = false;
        }
        if (AutoRotate)
        {
            transform.Rotate(0,speed * Time.deltaTime, 0);

        }
        else
        {
            if (Input.GetKey("a") || Input.GetKey("left"))
            {
                transform.Rotate(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                transform.Rotate(0, -speed * Time.deltaTime, 0);
            }
        }

    }
    public void RotateByArrows()
    {
        if (AutoRotate)
        {
            RotateByArrowsText.text = "Auto Rotate";
        }
        else
        {
            RotateByArrowsText.text = "Rotate by arrows";

        }
        AutoRotate = !AutoRotate;

    }
}
