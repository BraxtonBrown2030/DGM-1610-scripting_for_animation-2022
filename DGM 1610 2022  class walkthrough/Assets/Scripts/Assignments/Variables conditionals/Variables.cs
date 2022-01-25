using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Global varabile and other scritps 
    public int money; // whole number value 2,14,67,-92,-101

    public float change = 1.00f; // floating number or decimal 3.15, 105.34, -299.87
    
    public bool isDay = true; //  true is day and false is night and booleans are ture of false statments

    public bool eating = true;

    public string Loginname  = "Bob"; //string are alpha numrice text conataind in quotation marks

    // Start is called before the first frame update
    void Start()
    {
       money = 125;
       Debug.Log("Money in account = $" + money);

    }

    // Update is called once per frame
    void Update()
    {
        //check if it is day
        if(isDay == true)
        {
            print("It is Day!");
        }
        else if(isDay == false)
        {
            Debug.Log("It is night time");
        }

        // check if you can buy somthing 
        if(money > 100)
        {
            Debug.Log("you can buy");
        }
        else if(money < 100)
        {
            Debug.Log("You cannot buy");
        }
        // check change amount 
        if(change <= 1.00f)
        {
            Debug.Log("change is not one dollor");
        }
        else if(change > .99f)
        {
            Debug.Log("change is one dollor");
        }

        // eating 
        if(eating == true)
        {
            Debug.Log("is eating");
        }
        else if(eating == false)
        {
            Debug.Log("not eating");
        }

        // LoginName 

        if(Loginname == "Bob")
        {
            Debug.Log("welcome");
        }
        else
        {
            Debug.Log("Invaled Username");
        }
    }       
}
