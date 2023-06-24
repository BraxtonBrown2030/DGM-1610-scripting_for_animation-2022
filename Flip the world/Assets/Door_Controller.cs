using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    
    public AudioSource _Sorece;
    public AudioClip _Maker;
    private Player_Controller playerController;

    void Start()
    {
        
        playerController = GameObject.Find("Player").GetComponentInParent<Player_Controller>();

    }

    void OnTriggerEenter(Collider2D other)
    {

        if(other.CompareTag("Player") && playerController._key == 1)
        {
            Debug.Log("Door opens");
            Destroy(gameObject);
            _Sorece.PlayOneShot(_Maker, 1.0f);
        }
        else
        {
            Debug.Log("You need a key");
            Debug.Log("Go kill some ememys");
        }
    }
}
