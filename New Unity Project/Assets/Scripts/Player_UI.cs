using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_UI : MonoBehaviour
{
    [Header("Pickup numbers")]
    public int _socre;
    public TextMeshProUGUI _numberOfKey;


    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        
    }

    void UpdateScoreText()
    {

        _numberOfKey.text = "Score:  " + _socre;

    }
}