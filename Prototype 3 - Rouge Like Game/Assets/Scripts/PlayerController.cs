using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // speed of the player movement
    private Rigidbody2D rb; // rigidbody2d refrence for the script
    Vector2 movement; // stores the players x,y position for movement 

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
}
