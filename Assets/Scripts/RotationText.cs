using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RotationText : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] public TMP_Text textComp;

    void Start()
    {
        updateText(slider.value);
        slider.onValueChanged.AddListener(updateText);
    }

    // Update is called once per frame
    public void updateText(float val)
    {
        textComp.text = slider.value.ToString("F2");
    }
}
