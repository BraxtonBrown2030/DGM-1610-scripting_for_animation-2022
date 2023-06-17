using System.Collections;
using System.Collections.Generic;
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

    [Header("Scripts_Refrences")]
    public Player_Movement _player;

    [Header("Game_Objects")]
    public GameObject _Lootdrop;


    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player_Movement>();
    }


    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        if(_lastAttackTime >= -_attackSpeed)
        {
            Attack();
        }

    }

    void Attack()
    {

        Debug.Log("Enemy attack");

    }
}
