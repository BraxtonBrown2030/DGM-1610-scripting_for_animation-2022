using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Scor_Manager : MonoBehaviour
{
    public int _score;
    public Text _Scroetext;


    void Start()
    {
        UpdateScoreText();   
    }

    public  void IncreaseScoreText( int amount)
    {
        _score += amount;
        UpdateScoreText();
    }

    public void DecreaseScoreText(int amount)
    {
        _score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        _Scroetext.text = "Score: " + _score;
    }

}
