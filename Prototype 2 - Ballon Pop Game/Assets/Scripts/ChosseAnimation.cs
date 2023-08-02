using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosseAnimation : MonoBehaviour
{

    public Animation number1;
    public Animation number2;
    public Animation number3;
    public float numberToPick;

    public Transform[] pathway1;
    public Transform[] pathway2;
    public Transform[] pathway3;

    void Start()
    {
        
    }

  
    void Update()
    {
        
        numberToPick = Random.Range(1,3);


        if(numberToPick == 1)
        {


           
        }

    }
}
