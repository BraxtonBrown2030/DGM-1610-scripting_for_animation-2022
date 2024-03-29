using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UnityEngine;


public class Spanw_Manager : MonoBehaviour
{

    private float spawnTimer = 1f;
    private float spawnTimertop = 5;
    private float _spawnSpeed = 1f;

    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private GameObject _enemySlide;

    [SerializeField] private GameObject _Topenemy;

    [Header("Types of enemys")]
    public float maxNumberOfEmenys;
    public float maxSlide;
    public float maxTop;
    private Player_Movement player;
    //private bool _StopSpawning = true;
    
    private float numberofenemys;
    private float spawnMulty;
    private float wavenumber;


    void Start()
    {

        wavenumber = Time.time * wavenumber;

    }

    void Update()
    {
     

        if (Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Enemy").Length < maxNumberOfEmenys)
        {
            spawnTimer = Time.time + _spawnSpeed;

            Instantiate(_enemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }

        if(Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Slide_enemy").Length < maxSlide)
        {
            spawnTimer = Time.time + _spawnSpeed;

            Instantiate(_enemySlide, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);
        }


        if(Time.time > spawnTimer && numberofenemys <= 10)
        {

            Instantiate(_Topenemy, new Vector3(Random.Range(-9.5f, 10f), 4.0f, 0), Quaternion.identity);

        }


        /*
        if(Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Topenemy").Length < maxTop);

        {
            spawnTimer = Time.time + _spawnSpeed;

           

        }
        */
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
