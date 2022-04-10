using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("player movement")]
    private Rigidbody rb3D;
    public float moveSpeed = 20f;
    private float turnSpeed = 50.0f;
    private Vector3 movement;
    public Vector3 drirection;
    private float fImput;
    private float hImput;

    [Header("player health")]
    public int curHP;
    public int maxHP;   

    void Start()
    {
        rb3D = GetComponent<Rigidbody>();
        curHP = maxHP;
    }

    void Update()
    {
        hImput= Input.GetAxis("Horizontal");
        fImput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * fImput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hImput);
    }

    void FixedUpdate()
    {
        rb3D.MovePosition(rb3D.position + movement * moveSpeed * Time.deltaTime);
        UpdateDirection();
    }

    void UpdateDirection()
    {
       
    }
    void Die()
    {
        Destroy(gameObject);
    }

}
