using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer_Controller : MonoBehaviour
{
    [SerializeField]
    private float _LazerSpeed = 8;

    void Start()
    {

    }


    void Update()
    {
      transform.Translate(Vector3.up *_LazerSpeed * Time.deltaTime);
       
        DeSpawn();
    }

    void DeSpawn()
    {

        if(transform.position.y >= 8)
        {
            
        }

    }
}
