using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public int _MainMenu;


    // Start is called before the first frame update
    void Start()
    {
        
     SceneManager.LoadScene(_MainMenu);
     Debug.Log("load working");

    }

    // Update is called once per frame
    void Quit()
    {
        Application.Quit();

    }
}
