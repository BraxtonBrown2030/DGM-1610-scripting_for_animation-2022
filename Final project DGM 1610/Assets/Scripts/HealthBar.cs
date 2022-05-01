using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private int healthBar;
    public int scaleToIncrease;
    public int scaleToDecrease;
    public PlayerController playerController;
    public GameObject healthbar;

    
    void Start()
    {
        //healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();

    }

   
    void Update()
    {
        
    }
    public void SizeChangeOnDamage()
    {
        transform.localScale -= Vector3.one * scaleToDecrease;
    }
    public void OnHitChange()
    {
        if(playerController.curHP > playerController.maxHP)
        {
            SizeChangeOnDamage();
        }
    }
}
