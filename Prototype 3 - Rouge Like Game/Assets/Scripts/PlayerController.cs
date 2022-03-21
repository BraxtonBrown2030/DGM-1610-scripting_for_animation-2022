using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Health")]
    public int curHP; // hp at current time
    public int maxHP; // max hap of player 

    [Header("Player Movement")]
    public float moveSpeed = 5f; // speed of the player movement
    private Rigidbody2D rb; // rigidbody2d refrence for the script
    Vector2 movement; // stores the players x,y position for movement 

    [Header("Player Combat")]
    public float attackRange; // range of the player attack
    public float attackRate;  // the speed of the attacks
    private float lastAttackTime; 
    public int damage; // damage per attack
    public LayerMask enemyLayer; // the enemy layer within the unity editor

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {    
        movement.x = Input.GetAxis("Horizontal");// left right movenet for player 
        movement.y = Input.GetAxis("Vertical"); // gets the up down movement for player 
    }
    // set number of calls per frame 
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, attackRange, enemyLayer); // raycasting detects if it has it somtihng on the enemy layer if yes run code

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    void Die()
    {
        Debug.Log("You have Died");
    }
}
