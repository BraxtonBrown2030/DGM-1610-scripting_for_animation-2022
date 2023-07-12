using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.ComponentModel.Design.Serialization;
using UnityEngine.SocialPlatforms.Impl;

public class Wave_Manager : MonoBehaviour
{
    public int wave;
    public TextMeshProUGUI wavetext;
    public float amount = 1;
    public float wavetime;
    
    void Start()
    {
        

    }


    void Update()
    {

        wavetime = Time.time;
        Debug.Log(wavetime);

        if(wavetime <= 1)
        {
            UpdateWave();
        }

    }

    
    public void UpdateWave()
    {
        
        wavetext.text = "wave: " + wave;
        wavetime =wave;


    }
    /*
    public void IncreaseWave(int amount)
    {

        wave += amount;
        UpdateWave();

    }
    */
}
