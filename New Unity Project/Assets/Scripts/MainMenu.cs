using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
     public void StartGame()
    {
        // finds scene and loads disired scene
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        // closes currretn applacation on button press 
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
