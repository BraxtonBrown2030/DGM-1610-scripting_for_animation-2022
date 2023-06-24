using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Movement : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody rb;
    private Vector2 movement;
    private float hImput;
    private float vImput;
    private float turnSpeed = 100.0f;
    private float moveSpeed = 25.0f;

    [Header("Player Combat")]
    private float attackRange;
    private float attackSpeed;
    public int _damage;

    [Header("iteams")]
    public float iteam;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {

         hImput = Input.GetAxis("Horizontal");
             transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hImput);

         vImput = Input.GetAxis("Vertical");
             transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * vImput);


    if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

    }

    void Attack()
    {

        Debug.Log("this is working");

    }

    public void TakeDamage()
    {
        
    }
}
