using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlller : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP; // current Hp
    public int maxHP; // Max Hp

    [Header("enemy attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;

    [Header("Scripts")]
    public PlayerController player;

    [Header("drops")]
    public GameObject lootDrop;
 
    void Start()
    {
        // sets the player object
        player = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    void Update()
    {
        // checks if enmey can attack and how fast they can attack
        if(Time.time - lastAttackTime >= attackRange && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }

    }
    public void TakeDamage(int damage)
    {
        // changes hp when taking damge
        curHP -= damage;

        // checks hp if at value die and drops loot
        if(curHP <= 0)
        {
            Die();
            LootDrop();
        }
    }
    void Attack()
    {
        // makes sure player takes damge and set timer for last attack
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }

    void Die()
    {
        // removes enemy when no longer needess
        Destroy(gameObject);
    }
    void LootDrop()
    { 
        // finds the disired loot drop and places it in the sceen 
        Instantiate(lootDrop, transform.position, Quaternion.identity);
    }
}
