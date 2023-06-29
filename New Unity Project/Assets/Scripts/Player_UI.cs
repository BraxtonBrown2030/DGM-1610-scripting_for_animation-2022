using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_UI : MonoBehaviour
{
    [Header("Pickup numbers")]
    public int _score;
    public TextMeshProUGUI numberOfKeys;


    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        
    }

    void UpdateScoreText()
    {

        numberOfKeys.text = "Score:  " + _score;

    }
}