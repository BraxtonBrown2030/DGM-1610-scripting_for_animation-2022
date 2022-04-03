using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int socialClass = 1; 
    public int racePlacement;
    public float talkingNcp;
    public string responceTest;
    public string orderTest;
    public int prizeWheel;
    public int gearTip;
    public int skillSlot;
    public string manga;
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

            case "Prepare for combat":
             Debug.Log("on gaurd cretain");
            break;

            case "what would you like to bye":
             Debug.Log("thank you for buying that");
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

        switch(talkingNcp)
        {
            case 0:
             Debug.Log("hello welcom to are town");
            break;

            case 1:
             Debug.Log("This is the best town in the west");
            break;

            case 2:
             Debug.Log("Are you the hero");
            break;

            case 3:
             Debug.Log("are you going to save us");
            break;

            default:
             Debug.Log("who are you?");
            break;
        }

        switch(responceTest)
        {
            case "how are you":
             Debug.Log("I amd doing fine");
            break;

            case "are you ok":
             Debug.Log("I am not feeling ok");
            break;

            case "I am done":
             Debug.Log("thankyou for doing that");
            break;

            case "That was cool":
             Debug.Log("thank you for that");
            break;

            case "what are you doing":
             Debug.Log("I am makeing more weapons");
            break;
        }
        switch(orderTest)
        {
            case "What can I get you":
             Debug.Log("can i get a sandwitch");
            break;

            case "Do you need anything":
             Debug.Log("can i get some ranch");
            break;
            
            case "are you splting the cheak":
             Debug.Log("not it will be mone chek");
            break;

            case "have a good day":
             Debug.Log("You too");
            break;

            case "do you need a check":
             Debug.Log("yes can i get a check");
            break;
        }
        switch(prizeWheel)
        {
            case 0:
             Debug.Log("you have won a new car");
            break;

            case 1:
             Debug.Log("you have won a new house");
            break;

            case 2:
             Debug.Log("you have won money");
            break;

            case 3:
             Debug.Log("won have won a new toster");
            break;
            
            case 4:
             Debug.Log("you have won a small prize");
            break;
        }
        switch(gearTip)
        {
            case 0:
             Debug.Log("This gose in the head slot");
            break;

            case 1:
             Debug.Log("This gose int he body slot");
            break;

            case 2:
             Debug.Log("This dose in the arms slot");
            break;

            case 3:
             Debug.Log("This gose in the shoe slot ");
            break;

            case 4:
             Debug.Log("This gose in the wepaons slot");
            break;
        }
        switch(skillSlot)
        {
            case 0:
             Debug.Log("this skill cannot be put in the hotbar");
            break;

            case 1:
             Debug.Log("this skill can be put in the hotbar");
            break;

            case 2:
             Debug.Log("this skill can be augmented");
            break;

            case 3:
             Debug.Log("this skill cant be augmented");
            break;

            case 4:
             Debug.Log("this skill cannot be learend about this class");
            break;
        }
        switch(manga)
        {
            case "Dr.Stone":
             Debug.Log(" This manga had ended but is one of the best");
            break;

            case "Kuma Kuma kuma Bear":
             Debug.Log("This is a great and chill read");
            break;

            case "the new gate":
             Debug.Log("This is a great story and has lots of funny parts aswell");
            break;

            case "Bakuman":
             Debug.Log("This managa is about manking manga");
            break;
            
            case "Re monster":
             Debug.Log("this is about monster trying to live in a harsh world");
            break;
        }
    }
}
