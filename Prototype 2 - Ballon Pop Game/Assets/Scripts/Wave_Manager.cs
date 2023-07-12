using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.ComponentModel.Design.Serialization;

public class Wave_Manager : MonoBehaviour
{
    public int wave;
    public TextMeshProUGUI wavetext;
    public int amount;
    
    void Start()
    {
        UpdateWave();

    }


    void Update()
    {
        if(wave == 0)
        {

            UpdateWave();

        }


    }

    public void UpdateWave()
    {
        
        wavetext.text = "Wave:  " + wave;
        wave += amount;

    }

    public void IncreaseWave(int amount)
    {

        wave += amount;
        UpdateWave();

    }

}
