using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Health")]
    public int curHP; // hp at current time
    public int maxHP; // max hap of player 
    public HealthBar healthBar; // reeference the HealthBar Script

    [Header("Player Movement")]
    public float moveSpeed = 5f; // speed of the player movement
    private Rigidbody2D rb; // rigidbody2d refrence for the script
    public Vector2 direction;
    private Vector2 movement; // stores the players x,y position for movement 

    [Header("Player Combat")]
    public float attackRange; // range of the player attack
    public float attackRate;  // the speed of the attacks
    private float lastAttackTime; 
    public int damage; // damage per attack
    public LayerMask enemyLayer; // the enemy layer within the unity editor

    [Header("Inventory")]
    public int key;
    public int Coins;
    public int Gems;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {    
        movement.x = Input.GetAxis("Horizontal");// left right movenet for player 
        movement.y = Input.GetAxis("Vertical"); // gets the up down movement for player 

        if(Input.GetKeyDown(KeyCode.X)) // chosing the key press for the action
        {
            if(Time.time - lastAttackTime >= attackRate)
            {
                Attack();
            }
        }
    }
    // set number of calls per frame 
    void FixedUpdate() //using fixedupdate make movement and physisysc smothery than yousing other up date values
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer); // raycasting detects if it has it somtihng on the enemy layer if yes run code

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    void Die()
    {
        Debug.Log("You have Died");
    }

     public void TakeDamage(int damage)
    {
        curHP -= damage;
        // updates the health bar using curruent HP
        healthBar.SetHealth(curHP);

        if(curHP <= 0)
        {
            Die();
        }
    }
}
