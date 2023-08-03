using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public Scene secnetoload;

    void Start()
    {
        
    

    }

    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }


    void QuitGame()
    {
        Application.Quit();
    }
}
