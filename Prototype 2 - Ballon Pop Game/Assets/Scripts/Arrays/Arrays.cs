using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Aruthr", "Randall", "Tood", "Becky"};
    //  starts at 0 not 1         {0,        1,        2,      3,          4,      5,      6}
    public int[] numbers = {23,46,77,10,42,98,63,81};
    public string[] CandyBars = {"coco", "Nuts", "filling", "toptings", "wraper"};
    public float [] dec = {23.5f, 45.5f, 67.5f};
    public string[] CarNames = {"honda", "jeep", "dodge","tesla"};
    public string[] ItemNames = {"log", "stick", "sword", "hammer", "bannana", "stool"};
    public int[] TireSize = {10,20,30,45,55,60};
    public string[] Greatings = {"Hello", "Hi", "Good Morning", "How are you"};
    public string[] Goodbyes = {"See you later", "Bye", "have a nice day", "see you next time"};
    public float [] CM = {10.2f,34.6f,78.4f,56.5f};
    public int [] stoolsPerTable = {12,21,13,14,16,18};

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
       /* 
        // looping arays for reptartve tasks
        foreach( int numbers in numbers)
        {
            Debug.Log(numbers);
        }
        */
        /*
        foreach(string CandyBars in CandyBars) //candybar fillings and toppings 
        {
            Debug.Log(CandyBars);
            Debug.Log(CandyBars[3]+ " this will be filled with penutbutter ");
        }
       */
        Debug.Log(dec[0]+ " this is a number");
           
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
