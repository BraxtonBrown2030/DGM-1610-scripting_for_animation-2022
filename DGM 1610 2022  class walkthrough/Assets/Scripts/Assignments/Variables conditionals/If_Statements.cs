using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
   // public string lightColor;

   //public string weather;

   public string HairColor;

   public int age;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* this is a example of multy if statment 
        if(lightColor == "Red") 
        {
         Debug.Log("The light is "+ lightColor +" STOP!!!!" );
         }  
        else if(lightColor == "Yellow")
        {
           Debug.Log("The light is "+ lightColor +" start to Stop or Clear the intersection!" ); 
        }
        else if(lightColor == "Green")
        {
           Debug.Log("The light is "+ lightColor +" GO GO GO!" ); 
        }
        else
        {
            Debug.Log("Wrong color!");
        }
        */
        /* this is a weather conditonal 
        if(weather == "Rain" || weather == "Snow")
        {
            Debug.Log("The waether is bad, you should wear a coast!");
        }
        else if(weather == "Sunny" || weather == "Partly Cloudy")
        {
            Debug.Log("You do not need a coat!");
        }
        */
        if(HairColor == "red" && age == 6)
        {
            Debug.Log("You can ride the Merry GO Round!!");
        }
        else if(HairColor == "Blonde" && age == 100)
        {
            Debug.Log("You are old enough to ride the Fire Drgaon ride!!");
        }

    }
}
