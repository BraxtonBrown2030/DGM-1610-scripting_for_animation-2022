using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   
    public Canvas pauseMenu;
    public Canvas settingsMenu;

    void Start()
    {
        
        pauseMenu = GameObject.FindGameObjectWithTag("Pause Menu").GetComponent<Canvas>();

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Tab))
        {

            Time.timeScale = 0;
            PauseMenuON();

        }
        
    }

    public void PauseMenuON()
    {

        pauseMenu.enabled = true;

    }

    public void RusumeGame()
    {

        pauseMenu.enabled = false;
        Time.timeScale = 1;

    }

}
