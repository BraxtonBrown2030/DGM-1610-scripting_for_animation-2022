using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class Spanw_Manager : MonoBehaviour
{

    private float spawnTimer = 1f;
    private float _spawnSpeed = 1f;

    [SerializeField]
    private GameObject _enemy;
    public float maxNumberOfEmenys;
    private Player_Movement player;
    private bool _StopSpawning = false;
    


    void Start()
    {

        player = GameObject.Find("Player").GetComponent<Player_Movement>();

    }

    void Update()
    {


        if (Time.time > spawnTimer && GameObject.FindGameObjectsWithTag("Enemy").Length < maxNumberOfEmenys)
        {
            spawnTimer = Time.time + _spawnSpeed;

            Instantiate(_enemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }


    }
}
