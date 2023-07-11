using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu]
public class Offscreenballoon : ScriptableObject
{

    public int amnoutOfballoons;
    public float toReset;
    public Game_Manager game_Manager;

    void Start()
    {
        
        

    }

    void Update()
    {

        if(amnoutOfballoons == toReset)
        {

           SecneReset();

        }


    }
     public void SecneReset()
    {

        SceneManager.LoadScene("BalloonGame");
    }
}
