using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using TreeEditor;
using UnityEngine;

public class Enemy_Slide_Controller : MonoBehaviour
{
    [Header("Health")]
    private float _Health;

    [Header("movement / Attacks")]
    private int _Movespeed = -1;
    private float _Attackspeed = -0.5f;
    private float _LasttAttackTime = 1f;

    [Header("Scripts")]
    Spanw_Manager spanw_Manager;

    [Header("GameObjects")]
    [SerializeField]
    private GameObject _Lazer;
    public GameObject _Topenemy;
    public float maxtop = 1f;

    
    public float spawntimer = 1;
    public float spawntime = 1f;


    void Start()
    {
        
        maxtop = GameObject.FindGameObjectsWithTag("Top enemy").Length;

    }


    void Update()
    {
        
        Slide_Movement();

        if(Time.time > _Attackspeed)
        {
            Attack();
        }

        


    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            Player_Movement player = other.transform.GetComponent<Player_Movement>();

            if(player != null)
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

    void Slide_Movement()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _Movespeed);


        if(transform.position.y <= -6.5) // reuse spawn that go off screen
        {
            float _randomRangeX = Random.Range(-9.5f, 10f);

            transform.position = new Vector3 (_randomRangeX,8,0);

        }


        // movment for chaning driction when at the edge of the screen
        if(transform.position.x >= -9.5f && transform.position.x <= 0f)
        {

            transform.Translate(Vector3.left * Time.deltaTime * _Movespeed);
            transform.Translate(Vector3.down * Time.deltaTime);

        }

        else if(transform.position.x <= 10f && transform.position.x >= 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _Movespeed);
            transform.Translate(Vector3.down * Time.deltaTime);

        }
        
    }

    void Attack()
    {
        _Attackspeed = Time.time + _LasttAttackTime;
        Instantiate(_Lazer, transform.position + new Vector3 (0, -0.8f, 0), Quaternion.identity);

    }
}
