using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000;

    public float sidewaysForce = 500f;

    public float slideVal = SliderChange.sliderValue;
    void FixedUpdate() // Use FixedUpdate when dealing with Physics
    {
        if(forwardForce == 0)
        {
            forwardForce = 8000; // Defaults the player speed in case they don't load the options menu & player speed slider
        }
        else
        {
            forwardForce = 8000 * (SliderChange.sliderValue / 100); //Uses the value from the slider for player speed
        }
        
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // moves player forward

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
