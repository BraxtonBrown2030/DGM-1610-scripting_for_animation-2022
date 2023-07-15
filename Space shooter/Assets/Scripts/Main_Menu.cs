using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public int _Gamescene;


    // Start is called before the first frame update
    public void StartGame()
    {
        
     SceneManager.LoadScene(_Gamescene);
     Debug.Log("load working");

    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");

    }
}
