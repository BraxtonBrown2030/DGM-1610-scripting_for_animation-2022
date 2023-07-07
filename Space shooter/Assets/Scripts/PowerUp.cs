using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    [SerializeField]
    private float _moveSpeed = 3;

    private float _amountofpoweups;
    private float _Numberofpowerups;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * Time.deltaTime * _moveSpeed);

        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }

    }

     private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {

            Player_Movement player = other.transform.GetComponent<Player_Movement>();

            if(player != null)
            {
                player.TripleshotActive();
            }

            Destroy(this.gameObject);
        }

    }
}
