using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Aruthr", "Randall", "Tood", "Becky"};
    //  starts at 0 not 1         {0,        1,        2,      3,          4,      5,      6}
    public int[] numbers = {23,46,77,10,42,98,63,81};

    // Start is called before the first frame update
    void Start()
    {
        // how to change a attay value before game starts
        /*
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[3]+ "Says hi as he walks to class");
        friendNames[0] = "Veronica";
        Debug.Log("New friend " + friendNames[0]);
        */

        // looping arays for reptartve tasks
        foreach( int numbers in numbers)
        {
            Debug.Log(numbers);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
