using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //public int numEwoks = 20;  countinh up and down int 
    public int ducksInPond = 99;

    // Start is called before the first frame update
    void Start()
    {
        /*
        for(int i = 1; i <= numEwoks; i++) // counting up with for loops
        {
            Debug.Log(" There are " + i + " ewoks jumping on the bed ");
        }
        */
        /*
        for(int i = 20; i >= numEwoks; i--) // counting down with for loops
        {
            Debug.Log(" There are " + i + " ewoks jumping on the bed ");
        }
        */

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
