using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.ComponentModel.Design.Serialization;
using UnityEngine.SocialPlatforms.Impl;
using System.Threading;

public class Wave_Manager : MonoBehaviour
{
    public int wave;
    public TextMeshProUGUI wavetext;
    public float amount = 1;
    public float wavetime;
    
    
    void Start()
    {
        
        //wave = GameObject.FindGameObjectWithTag("Score Manager").GetComponent<Scoreman>;
    }


    void Update()
    {
        /*
        Time.timeScale = 0.5f;

        //Debug.Log(wavetime);

        wavetime = Time.time;

        if(wavetime <= 1)
        {
            UpdateWave();
        }

        if(scoreManager.score == 1000)
        {

            wave = 1;
            UpdateWave();

        }
                if(scoreManager.score == 5000)
        {

            wave = 2;
            UpdateWave();

        }

                if(scoreManager.score == 10000)
        {

            wave = 3;
            UpdateWave();
            
        }
        */
    }

    
    public void UpdateWave()
    {
        
        wavetext.text = "wave: " + wave;
        wavetime = wave;


    }

    public void Awake()
    {



    }
    
}
