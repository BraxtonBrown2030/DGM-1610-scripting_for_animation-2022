using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spanw_Manager : MonoBehaviour
{

    private float spawnTimer = 1f;
    private float _spawnSpeed = 1f;

    [SerializeField]
    private GameObject _enemy;

    void Start()
    {
        
    }

    void Update()
    {
    
        if(Time.time > spawnTimer)
        {
            spawnTimer = Time.time + _spawnSpeed;
            //new Vector3(Random.Range(-9.5f, 10f), 0, 0);

            Instantiate(_enemy, new Vector3(Random.Range(-9.5f, 10f), 0, 0), Quaternion.identity);

        }


    }
}
