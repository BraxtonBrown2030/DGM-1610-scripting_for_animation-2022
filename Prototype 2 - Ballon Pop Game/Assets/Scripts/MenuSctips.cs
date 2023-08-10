using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSctips : MonoBehaviour
{
    
    public Canvas pauseCanvas;
    public Canvas deathcanvas;
    public Canvas startPopUp;


    void Start()
    {
        pauseCanvas = GameObject.FindGameObjectWithTag("Pause Menu").GetComponent<Canvas>();
        deathcanvas = GameObject.FindGameObjectWithTag("Death Menu").GetComponent<Canvas>();

    }

    
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Tab))
        {

            Time.timeScale = 0;
            pauseCanvas.enabled = true;


        }
        

    }

    public void Restart()
    {

        SceneManager.LoadScene(1);

    }
    public void Return()
    {

        pauseCanvas.enabled = false;
        Time.timeScale = 1;

    }

    public void ClosePopUP()
    {

        startPopUp.enabled = false;
        Time.timeScale = 1; 

    }

    public void ClosePausedMenu()
    {

        pauseCanvas.enabled = false;
        Time.timeScale = 1;

    }

    public void Mainmenu()
    {

        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {

        Application.Quit();

    }

}
