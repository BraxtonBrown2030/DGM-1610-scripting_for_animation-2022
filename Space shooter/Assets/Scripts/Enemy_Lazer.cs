using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TreeEditor;
using UnityEngine;

public class Enemy_Lazer : MonoBehaviour
{
    [SerializeField]
    private float _LazerSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {

        transform.Translate(Vector3.down *_LazerSpeed * Time.deltaTime);

        if(transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    
    
    }
    
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            Player_Movement player = other.transform.GetComponent<Player_Movement>();

            if(player != null)
            {

                player.TakeDamage();

            }

            Destroy(this.gameObject);

        }

    }

}
