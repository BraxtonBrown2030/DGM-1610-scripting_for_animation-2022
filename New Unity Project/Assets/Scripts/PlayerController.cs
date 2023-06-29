using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class PlayerController : MonoBehaviour
{
    [Header("Player movement")]
    public float moveSpeed;
    private Rigidbody2D rd;
    public Vector2 direction;
    private Vector2 movement;
    private Vector2 mouseImput;
    public float mouseSensitivty = 4.0f;

    [Header ("Player health")]
    public int maxHP;
    public int curHP;

    [Header("Player combat")]
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public int damage;
    public LayerMask enemylayer;

    [Header("Inventroy")]
    public int key;
    public int coins; 
    public int ammon;

    [Header("Sound Effects")]
    public AudioSource source;
    public AudioClip maker;

    [Header("Scripts")]
    public HealthBar hpBar; // finds health bar from game assets
    public int sceneToLoad;


    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        curHP = maxHP; //set max HP
        hpBar.SetHealth(maxHP); // sets hp bar on canvas 
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // get unity inbuilt movment setteing to move player
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            //if(Time.time - lastAttackTime >= attackRange)
            {}
                Attack();
                Debug.Log("Attack works");
                source.PlayOneShot(maker, 1.0f);
            
        }
        /*
        if(Input.GetKeyDown(KeyCode.C))
        // changes the screen rotaion
        {
            transform.rotation =  Quaternion.Euler(0,180,0);    
            movement.x = movement.y;
            movement.y = movement.x;
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            //sets screen rotaion to defult
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        */
        
        
         if(Input.GetKeyDown(KeyCode.V))
        {      
            transform.rotation = Quaternion.Euler(0,90,0);
        }

         if(Input.GetKeyDown(KeyCode.C))
        {          
            transform.rotation = Quaternion.Euler(0,-90,0);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            transform.rotation = quaternion.Euler(0,180,0);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.rotation = quaternion.Euler(0,0,0);
        }

    }
    void FixedUpdate()
    {
        // helps smooth player movment and jitteryness
        rd.MovePosition(rd.position + movement * moveSpeed * Time.deltaTime);
        UpdateDirection();
        
    }
    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }
        rd.velocity = vel * moveSpeed;
    }

    void Attack()
    {
        // set attack timer 
        lastAttackTime = Time.time;

        // finds and sets enemy layer to attack
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemylayer);

        if(hit.collider != null)
        {
            // if the ray casting find the enmey then they take damge
            hit.collider.GetComponent<EnemyControlller>()?.TakeDamage(damage);
        }
    }

    void Die()
    {
        Debug.Log("You have Died");
        SceneManager.LoadScene(sceneToLoad);
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage; // set current hp to new value after set damage
        hpBar.SetHealth(curHP); // sets hp bar to current health total

        if(curHP <= 0)
        {
            Die();
        }
    }

}
