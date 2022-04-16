using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;  //count in up and down int 
    public int ducksInPond = 99;
    public int carsInLot = 20;
    public int shoppersInStore;

    
    void Start()
    {
        for(int i = 1; i <= numEwoks; i++) // counting up with for loops
        {
            Debug.Log(" There are " + i + " ewoks jumping on the bed ");
        }       
        
        for(int i = 20; i >= numEwoks; i--) // counting down with for loops
        {
            Debug.Log(" There are " + i + " ewoks jumping on the bed ");
        } 

        for(int i = 20; i <= carsInLot; i++)  
        {
            Debug.Log (" There are " + i + " Cars in the lot right now");
        }  
        
        for (int i = 20; i >= carsInLot; i--)
        {
            Debug.Log(" There are " + i + " cars in the lot right now");
        } 
        for (int i = 20; i <= shoppersInStore; i++)
        {
            Debug.Log(" ther are too many shoppers they amount to " + i + "plz let not others in");
        }

        for (int i = 20; i >= shoppersInStore; i--)
        {
            Debug.Log("there are no shoppers in the store they equle to" + i + "plz go avririse");
        }

        

        while(ducksInPond > 0) // counting down with a while loop 
        {
            Debug.Log(ducksInPond);
            ducksInPond --; // do not forget can make infines loop and break everthing 
            Debug.Log("All of the ducks have gone away for the winter");
        }
        
        while(ducksInPond < 99) // counting up with whlie loop
        {
            Debug.Log(ducksInPond);
            ducksInPond ++; // do not forget can make a game braking loop 
            Debug.Log("there are too many ducks");
        }

        while(carsInLot < 20)
        {
            Debug.Log(carsInLot);
            carsInLot ++; // do not forget
            Debug.Log(" there are so many cars ");
        }

        while(carsInLot > 0)
        {
            Debug.Log(carsInLot);
            carsInLot --; // do not forget
            Debug.Log("there are no cars left");
        }

        while(shoppersInStore < 20)
        {
            Debug.Log(shoppersInStore);
            shoppersInStore ++;
            Debug.Log(" there are more shoppers ");
        }

        while(shoppersInStore > 0)
        {
            shoppersInStore --;
            Debug.Log(shoppersInStore);
            Debug.Log(" the are not shoppers in the store ");         
        }
        
    }
}
