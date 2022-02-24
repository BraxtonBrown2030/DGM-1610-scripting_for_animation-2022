using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    //public int balloonIndex;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        // Get a Random postion on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10,0);
        // Pick random balloon from the balloonPrefab array or pick form balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        // Spawn random balloon at spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex]. transform.rotation);

    }
}
