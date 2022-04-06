using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem,}
    public PickupType currentPickup;
    public int pcikupAmount;  
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pcikupAmount;
                Debug.Log("You have a picked up a Key!");
            }
            else if (currentPickup == PickupType.Coin)
            {
                playerController.Coins += pcikupAmount;
                Debug.Log(" you have picked up " + pcikupAmount + " Coins ");
            }
            else if (currentPickup == PickupType.Gem)
            {
                playerController.Gems += pcikupAmount;
                Debug.Log(" you have picked up " + pcikupAmount + " Gems ");
            }
            Destroy(gameObject);
            // ask about adding a random.range to the amount picked up 
        }
    }
}
