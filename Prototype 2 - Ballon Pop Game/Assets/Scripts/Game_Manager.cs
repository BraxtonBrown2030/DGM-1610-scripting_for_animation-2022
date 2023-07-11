using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_Manager : MonoBehaviour
{
    
    [SerializeField] private float health;
    public Balloon red_Balloon;
    public Balloon blue_Balloon;
    public Offscreenballoon secneReset;

  

    void Start()
    {
        
        red_Balloon = GameObject.Find("Red_Balloon").GetComponent<Balloon>();

        secneReset = GameObject.Find("OffScrene").GetComponent<Offscreenballoon>();
      
        health = 3;

    }


    void Update()
    {
        
        if(red_Balloon.transform.position.y <= -9f)
        {

           health -= 1;

        }
        else if (health == 0)
        {

        

        }
        
        

    }
}
