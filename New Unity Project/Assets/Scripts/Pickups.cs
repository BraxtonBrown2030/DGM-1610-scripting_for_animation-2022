using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem}
    public PickupType currentPickup;
    public int pcikupAmount;
    private PlayerController playerController;
    void Start()
    {
        // refrences player contorller
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // checks if player is so give item and detroy game object
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pcikupAmount;
                Debug.Log("You have picked up a key");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins += pcikupAmount;
                Debug.Log("you have picked up" + pcikupAmount + "conis");
            }
            else if(currentPickup == PickupType.Gem)
            {
                playerController.ammon += pcikupAmount;
                Debug.Log("you have picked up" + pcikupAmount + "bullets");
            }
            Destroy(gameObject);
        }
    }
}
