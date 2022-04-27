using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        // sence to load
        
    }

    public void QuitGame()
    {
        Application.Quit(); // quit game 
        Debug.Log("Quit Game"); // print test
    }
}
