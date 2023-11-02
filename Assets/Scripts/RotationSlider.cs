using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{
    public Slider rotationSlider;
    public GameObject player;
    void Start()
    {
        rotationSlider.minValue = 0;
        rotationSlider.maxValue = 360;

        rotationSlider.onValueChanged.AddListener(rotationSliderUpdate);
    }

    private void rotationSliderUpdate(float value)
    { 
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);

    }
     
}
