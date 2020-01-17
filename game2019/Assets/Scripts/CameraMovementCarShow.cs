using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementCarShow : MonoBehaviour
{
    public float speed = 20.0f;
    public bool AutoRotate = false;
    void Update()
    {
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
            if (Input.GetKey("w") || Input.GetKey("up"))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("s") || Input.GetKey("down"))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }

    }
}
