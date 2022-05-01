using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invintory : MonoBehaviour
{
    public enum Pickuptpye {Key, Coin, Ammo}
    public Pickuptpye currentPickup;
    public int pickupAmount;
    private PlayerController playerController;
  
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void OnTriggerenter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == Pickuptpye.Key)
            {
                playerController.key = pickupAmount;
                Debug.Log("You got a key");
            }
            else if(currentPickup == Pickuptpye.Ammo)
            {
                playerController.ammo += pickupAmount;
                Debug.Log("you have picked up" + pickupAmount + " bullets");
            }
            else if (currentPickup == Pickuptpye.Coin)
            {
                playerController.coin += pickupAmount;
                Debug.Log("you have pickedup" + pickupAmount + "of coins");
            }
        }
    }
}
