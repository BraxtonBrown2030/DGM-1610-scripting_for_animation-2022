using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Doormanager : MonoBehaviour
{
    public AudioSource _Sourse;
    public AudioClip _maker;
    private Player_Movement player_Movement;


    void Start()
    {
        
        player_Movement = GameObject.Find("Player").GetComponentInParent<Player_Movement>();
    }

    void OntriggerEnetr2D(Collider2D other)
    {
        if(other.CompareTag("Player") && player_Movement._iteam == 1)
        {

            Debug.Log("Door opens");
            Destroy(gameObject);
            _Sourse.PlayOneShot(_maker, 1.0f);

        }
        else
        {
            Debug.Log("you need a key");
            Debug.Log("Go kill more enemys");

        }

    }
}
