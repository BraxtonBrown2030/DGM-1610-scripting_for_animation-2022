using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int socialClass = 1; 
    public int racePlacement;
    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
            Debug.Log("hello good sir mat the god bless you");
            break; // this it a stoper foe the casees same and the ; for other code
            case "Goodbye":
            Debug.Log("Safe travles to you");
            break;
            case "foul banded prepare to die":
            Debug.Log("arm thy self");
            break;

        }
        
        
        switch(socialClass)
        {
            case 5:
             Debug.Log("Hello you're Magesty!");
            break;

            case 4:
             Debug.Log("Hello young Princess!");
            break;

            case 3:
             Debug.Log("Good evening Duke Urthor");
            break;

            case 2:
             Debug.Log("Hello, Mayor!");
            break;

            case 1:
             Debug.Log("My i have something to eat");
            break;

            case 0:
             Debug.Log("Get away form me you scum!");
            break;

            default:
             Debug.Log("I do not talk to strangers!!");
            break;
        }

        switch(racePlacement)
        {
            case 5:
             Debug.Log("better luck next time");
            break;

            case 4:
             Debug.Log("so close keep trying");
            break;

            case 3:
             Debug.Log("congrats on making too top 3");
            break;

            case 2:
             Debug.Log("congrats on second palce");
            break;

            case 1: 
             Debug.Log("you won the race");
            break;
        }
        
    }

}
