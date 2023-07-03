using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;


public class Spanw_Manager : MonoBehaviour
{

    private float spawnTimer = 1f;
    private float _spawnSpeed = 1f;

    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private GameObject _enemySlide;

    [Header("Types of enemys")]
    public float maxNumberOfEmenys;
    public float maxSlide;
    private Player_Movement player;
    //private bool _StopSpawning = true;
    


    void Start()
    {


    }

    void Update()
    {
        spawnTimer = Time.time + _spawnSpeed;

        if (Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Enemy").Length < maxNumberOfEmenys)
        {
            spawnTimer = Time.time + _spawnSpeed;

            Instantiate(_enemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }

        if(Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Slide_Enemy").Length < maxSlide)
        {
            Instantiate(_enemySlide, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);
        }
    }
    /*
         else if(_StopSpawning == false)
        {
           
           // stops spawning

        }

    }

    public void OnPlayerDeath()
    {

        _StopSpawning = false;
        maxNumberOfEmenys = 0;
        GameObject.Destroy(_enemy);
    }
    */
}
