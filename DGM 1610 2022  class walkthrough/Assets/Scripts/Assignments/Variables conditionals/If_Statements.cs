using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
   public string lightColor;

   public string Books;

   public string HairColor;

   public int age;

   public float Change = 1.00f;

    public bool yes = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
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
        
        
        if(Books == "paper" || Books == "Hard cover")
        {
            Debug.Log("You can return this book!!");
        }
        else if(Books == "Damaged" || Books == "Ripped")
        {
            Debug.Log("You cannot return this book");
        }
        
        if(HairColor == "red" && age == 6)
        {
            Debug.Log("You can ride the Merry GO Round!!");
        }
        else if(HairColor == "Blonde" && age == 100)
        {
            Debug.Log("You are old enough to ride the Fire Drgaon ride!!");
        }

        if(Change > 1.00f)
        {
            Debug.Log("Transaction valid");
        }  
        else if(Change < 1.00f)
        {
            Debug.Log("Transaction invalid");
        } 

        if(yes == true)
        {
            Debug.Log("yes");
        }
        else if(yes == false)
        {
            Debug.Log("NO");
        }
    }
}
