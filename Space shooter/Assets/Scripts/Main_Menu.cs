using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public int _Gamescene;
    public int _Settings;
    public int _MainMenu;

    public void StartGame()
    {
        
     SceneManager.LoadScene(_Gamescene);
     Debug.Log("load working");

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");

    }


    public void Settings()
    {

        SceneManager.LoadScene(_Settings);

    }

    public void Back()
    {

        SceneManager.LoadScene(_MainMenu);

    }
}
