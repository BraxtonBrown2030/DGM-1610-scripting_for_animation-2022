using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        // gets key press and quits game
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
