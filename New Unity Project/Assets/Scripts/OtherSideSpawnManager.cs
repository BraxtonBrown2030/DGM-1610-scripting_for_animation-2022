using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSideSpawnManager : MonoBehaviour
{
    public GameObject enemy; // find object to refrence
    public float startDelay;
    public float respawnDelay;
    public float timer;
    void Start()
    { 
        // sets spawn timer depending on variables 
        InvokeRepeating("SpawnRandomEnemy", startDelay, respawnDelay);
    }

    void SpawnRandomEnemy()
    {
       // find object to refrence
        Instantiate(enemy, transform.position, Quaternion.Euler(0,180,0));
    }
}
