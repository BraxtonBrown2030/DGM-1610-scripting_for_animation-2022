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
    public float _UpSpeed = 1;
    public bool antimation = false;
    public Transform pointA;
    public Transform pointB;
    public float stopDistance;
    public float speed = 2;
    public float _timetoshot;
    public float _shoorscooldown;

    void Start()
    {
        pointA = GameObject.FindGameObjectWithTag("PointA").GetComponent<Transform>();
        pointB = GameObject.FindGameObjectWithTag("PointB").GetComponent<Transform>();
        

    }


    void Update()
    {
        

        if(transform.position.y <= 5.5f)
        {

            transform.Translate(Vector3.up * Time.deltaTime * _UpSpeed);

        }

        if(Vector3.Distance(transform.position, pointA.position) == stopDistance)
        {

            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);

            Debug.Log("movement works");

        }
        else if(Vector3.Distance(transform.position, pointB.position) == stopDistance)
        {

             transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);


        }


        if(_timetoshot >= _shoorscooldown)
        {

            Attack();

        }



    }


    void Attack()
    {
 

        Instantiate(_lazer,transform.position, Quaternion.identity);


    }
}
