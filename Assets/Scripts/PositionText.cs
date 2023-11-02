using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PositionText : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    public Transform referenceObject;

    void Update()
    {
        scoreText.text = (player.position.x-referenceObject.position.x).ToString("F2") + "  " + (player.position.y - referenceObject.position.y).ToString("F2");
    }
}
