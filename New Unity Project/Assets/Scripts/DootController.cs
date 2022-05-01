using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DootController : MonoBehaviour
{
    public AudioSource source;
    public AudioClip maker;
    private PlayerController playerController;
    void Start()
    {
        // find the playercontroller to find the keys
        playerController = GameObject.Find("Player").GetComponentInParent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // checks player to see if you have a key and if you do destorys the door
        if(other.CompareTag("Player") && playerController.key == 1)
        {
            Debug.Log("Door opens");
            Destroy(gameObject);
            source.PlayOneShot(maker, 1.0f);
            
        }
        else
        {
            Debug.Log("you need a Key");
            Debug.Log("Go Kill some enemys");
        }
    }
}
