using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [Header("PLayer momenent")]
        public float speed;
        public float jumpHight;
        private Rigidbody2D rb2D;

  [Header("Ground Check")]
        public Transform groundCheck;
        public float groundCheckRadius;
        public LayerMask whatIsGround;
        private bool isGrounded;

        private float moveVelocity;
    
    void Start()
    {
         isGrounded = true;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update() // fixed number of frams to make game run the same on all platforms
    {
        // ground Check Sensor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Non-Stick Player
        moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }

        // move player left and right basesd on velcity in the RB
        rb2D.velocity = new Vector2(moveVelocity, rb2D.velocity.y);

         if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHight);
    }
}
