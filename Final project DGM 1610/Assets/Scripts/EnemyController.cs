using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{   
    [Header("Health")]
    public int totalHealth;
    public int curHealth;

    [Header("Eenemy attack")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;

    [Header("Scrtips")]
    public PlayerController player;

    [Header("Drops")]
    public GameObject lootdrop;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector3.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;

        if(curHealth <= 0)
        {
            Die();
            LootDrop();
        }
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void LootDrop()
    {
        Instantiate(lootdrop, transform.position, Quaternion.identity);
    }
}
