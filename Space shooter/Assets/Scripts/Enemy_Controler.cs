using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Enemy_Controler : MonoBehaviour
{
    [Header("Movement")]
    private int moveSpeed = -5;

    [Header("Attack")]
    public int _damage;
    public float _attackSpeed;
    public float _lastAttackTime;

    [Header("Health")]
    public int _totalHeath;
    public int _curHealth;

    [Header("Game_Objects")]
    public GameObject _Lootdrop;
 
    void Start()
    {
        
    }


    void Update()
    {
        
        if(transform.position.x >= -9.5f && transform.position.x <= 0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        
        else if(transform.position.x <= 10f && transform.position.x >= 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

        if(transform.position.y >= -6.5)
        {
            Destroy(gameObject);
        }
        

        if(_lastAttackTime >= -_attackSpeed)
        {
            Attack();
        }

    }

    public void TakeDamage()
    {
        
    }

    void Attack()
    {

    }

    void Die()
    {
        Destroy(gameObject);
    }

    void LootDrop()
    {
        Instantiate(_Lootdrop, transform.position, Quaternion.identity);
    }
}
