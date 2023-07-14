using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.VFX;

public class Enemy_Controler : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private int moveSpeed = -4;

    [Header("Attack")]
    public int _damage;
    public float _attackSpeed;
    public float _lastAttackTime;

    [Header("Health")]
    public int _totalHeath;
    public int _curHealth;

    [Header("Game_Objects")]
    public GameObject _Lootdrop;
    public GameObject _TopEnemy;
 
    void Start()
    {
        
    }


    void Update()
    {
        Movement();

        if(_lastAttackTime >= -_attackSpeed)
        {
            Attack();
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hti: " + other.transform.name);

        if(other.tag == "Player")
        {
            Player_Movement player = other.transform.GetComponent<Player_Movement>();

            if (player != null)
            {
                player.TakeDamage();
            }

            Destroy(gameObject);
        }

        if(other.tag == "Lazer")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            
            
        }

    }

    void Attack()
    {

    }

    void Movement()
    {

        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
     /*
        if(transform.position.x >= -9.5f && transform.position.x <= 0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        
        else if(transform.position.x <= 10f && transform.position.x >= 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            transform.Translate(Vector3.down * Time.deltaTime);
        }
     */

        if(transform.position.y <= -6.5) // spawn range on droping past screen
        {

            float _randomRangeX = Random.Range(-9.5f, 10f);

            transform.position = new Vector3 (_randomRangeX,8,0);

        }

    }
}
