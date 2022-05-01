using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enmey; // find object to refrence
    public float startDelay = 1.0f;
    public float respawnDelay = 1.0f;
    public float timer = 2.0f;
    void Start()
    {
          // sets spawn timer depending on variables 
        InvokeRepeating("SpawnRandomEnemy", startDelay, respawnDelay);   
    }

    void SpawnRandomEnemy()
    {
        // find object to refrence
        Instantiate(enmey, transform.position, Quaternion.Euler(0,0,0));         
    }
}
