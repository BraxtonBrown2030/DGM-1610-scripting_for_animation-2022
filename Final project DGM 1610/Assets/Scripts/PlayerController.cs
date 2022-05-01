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
    public float maxDistance;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
    public LayerMask enemyLayer;

    [Header(" Invintory")]
    public int key;
    public int coin;
    public int ammo;

    [Header("Sound Effects")]
    private AudioSource source;
    public AudioClip marker;

    [Header("scripts")]
    public HealthBar hpBar;


    void Start()
    {
        rb3D = GetComponent<Rigidbody>();
        curHP = maxHP;

        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        hImput= Input.GetAxis("Horizontal");
        fImput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * fImput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hImput);
        
        if(Input.GetMouseButtonDown(0))
     {
        Attack();
        Debug.Log("i have hit theme");
        source.PlayOneShot(marker, 1.0f);
     }
    
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

    public void Attack()
    {
        lastAttackTime = Time.time;
        
        RaycastHit hit = Physics.Raycast(transform.position, transform.forward, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<EnemyController>()?.TakeDamage(damage);
            Debug.Log("this is working");
        }
        
    }
}
