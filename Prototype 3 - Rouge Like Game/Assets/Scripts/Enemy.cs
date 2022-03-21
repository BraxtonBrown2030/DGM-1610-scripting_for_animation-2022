using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;
    [Header("Enemy Attack")]
    public int damage;
    public float attackRate;
    private float lastAttackTime;

    [Header("Scripts")]
    public PlayerController player;

    void Start()
    {
        player = PlayerController.find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate)
        {
            Attack();
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            Die();
        }
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        PlayerController.TakeDamage(damage);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

