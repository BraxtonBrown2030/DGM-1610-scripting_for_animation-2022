using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

         movement.x = Input.GetAxis("Horizantal");
         movement.y = Input.GetAxis("Vertical");

    if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Attack();
            
        }

    }

    void Attack()
    {



    }
}
