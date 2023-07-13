using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Enemy_Top : MonoBehaviour
{

    [Header("stats")]
    public float health;
    public float danamge;
    public GameObject _lazer;
    

    void Start()
    {

        

    }


    void Update()
    {
        

        if(transform.position.y == 9)
        {

            transform.Translate(0,9,0);

        }

    }
}
