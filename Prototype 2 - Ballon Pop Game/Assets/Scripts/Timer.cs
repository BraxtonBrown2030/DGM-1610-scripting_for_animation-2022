using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
   
    public TextMeshProUGUI timeText;
    public float timeerNumber;


    public void Start()
    {



    }


    public void Update()
    {

        timeerNumber = Time.time / 0.6f;

        timeerNumber = Mathf.Round(timeerNumber * 10.0f) * 0.1f;

        timeText.text = "Timer:  " + timeerNumber;


    }

}
