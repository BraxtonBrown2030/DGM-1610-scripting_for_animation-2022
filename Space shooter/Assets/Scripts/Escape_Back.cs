using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape_Back : MonoBehaviour
{

    public int _MainMenu;

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(_MainMenu);

        }


    }
}
