using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.UIElements;

public class Player_Movement : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody rb;
    private Vector2 movement;
    private float hImput;
    private float vImput;
    //private float turnSpeed = 100.0f;
    //private float moveSpeed = 25.0f;
    public float _speed;

    [Header("Player Combat")]
    private float attackRange;
    private float attackSpeed;
    public int _damage;
    
    [SerializeField]
    private GameObject _Lazer;

    [Header("iteams")]
    public float _iteam;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        Debug.Log("game is running");
        Movement();

    if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    
    }

    void Movement()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        if(transform.position.y >= 0)
         {
             transform.position = new Vector3(transform.position.x,0,0);
         }
        else if(transform.position.y <= -3.8f)
         {
             transform.position = new Vector3(transform.position.x, -3.8f, 0);
         }

        if(transform.position.x >= 11)
         {
             transform.position = new Vector3(-11,transform.position.y,0);
         }
        else if (transform.position.x <=-11)
         {
             transform.position = new Vector3(11,transform.position.y,0);
         }
    
    }

    void Attack()
    {

        Debug.Log("this is working");

        Instantiate(_Lazer, transform.position, Quaternion.identity); // Qutarnion.identity = defalt postion

    }

    public void TakeDamage()
    {
        
    }
}
