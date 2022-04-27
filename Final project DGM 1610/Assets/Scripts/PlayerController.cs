using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody rb3D;
    public float moveSpeed = 20f;
    private float turnSpeed = 50.0f;
    private Vector3 movement;
    public Vector3 drirection;
    private float fImput;
    private float hImput;

    [Header("Player Health")]
    public int curHP;
    public int maxHP;   

    [Header ("Player Combat")]
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
    public LayerMask enemyLayer;


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
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

    }

    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, drirection, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<EnemyController>()?.TakeDamage(damage);
        }
    }
}
