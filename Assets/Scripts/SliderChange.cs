using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Text sliderText;
    public Slider slider;
    public static float sliderValue;

    void Start()
    {
        sliderValue = 50; // Defaults slider value to 50%
    }
    // Update is called once per frame
    void Update()
    {
        if (slider.value < 50)
        {
            slider.value = 50;
        }
        else
        {
            sliderValue = ((float)slider.value);
            sliderText.text = "Player Speed: " + slider.value.ToString() + "%";
        }
    }
}
