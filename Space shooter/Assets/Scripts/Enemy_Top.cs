using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Enemy_Top : MonoBehaviour
{
    [Header("Health")]
    public float health;
    
    private Transform player;
    public float _StopDistance = 7;
    public float _Speed = 2;
    public GameObject _Laser;
    public float _Attackspeed = -1f;
    public float _LastAttackTime = 1f;

    void Start()
    {
        
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }


    void Update()
    {
        
        if(Vector3.Distance(transform.position, player.position) > _StopDistance) // fllowing
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, _Speed * Time.deltaTime);
        }
        
        if(transform.position.y <= 5.5f) // downward barrirer
        {

            transform.position = new Vector3(transform.position.x,5.5f,0);

        }

        if( Time.time >= _Attackspeed)
        {

            Attack();

        }

    }

    void Attack()
    {

        _Attackspeed = Time.time + _LastAttackTime;

        Instantiate(_Laser, transform.position + new Vector3(0,-0.8f,0), Quaternion.identity);

    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("HIT:  " + other.transform.name);

        if(other.tag == "Player")
        {
            Player_Movement player = other.transform.GetComponent<Player_Movement>();

            if(player != null)
            {
                player.TakeDamage();
            }

        }

        if(other.tag == "Lazer")
        {

            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

    }

}
