using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerenter(Collider other)
    {
        if(other.CompareTag("Player") && playerController.key ==1)
        {
            Debug.Log("The door has opened");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("You need a key");
        }


    }    
}
