using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
   
    public TextMeshProUGUI timeText;
    public float timeerNumber;

    public float coutdownnumber = 7;


    public void Start()
    {



    }


    public void Update()
    {

        timeerNumber = Time.time / 0.6f;

        timeerNumber = Mathf.Round(timeerNumber * 10.0f) * 0.1f;

        timeText.text = "Timer:  " + timeerNumber;

        if(coutdownnumber >= 0)
        {

            TimerCountdown();

        }

        else if(coutdownnumber == 0)
        {

            

        }


    }

    public void TimerCountdown()
    {
    


        coutdownnumber -= Mathf.Round(timeerNumber * 10.0f) * 0.1f * 0.6f + Time.deltaTime;

        Debug.Log("Countdown: " + coutdownnumber);

        if(coutdownnumber == 0)
        {



        }

    }

}
