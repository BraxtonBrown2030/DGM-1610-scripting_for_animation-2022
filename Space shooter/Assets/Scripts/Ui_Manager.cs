using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Ui_Manager : MonoBehaviour
{
    [SerializeField]
    public Text _score;
    
    void Start()
    {
        _score.text = "Score:  " + 0;
    }

    public void UpdateScore(int playerscore)
    {
        _score.text = "Score:  " + playerscore.ToString();
    }
}
