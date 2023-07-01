using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.VFX;

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

        if(transform.position.y >= -6.5) // spawn range on droping past screen
        {

            float _randomRangeX = Random.Range(-9.5f, 10f);

            transform.Translate(new Vector3 (_randomRangeX,7,0));

        }
        

        if(_lastAttackTime >= -_attackSpeed)
        {
            Attack();
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        

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
