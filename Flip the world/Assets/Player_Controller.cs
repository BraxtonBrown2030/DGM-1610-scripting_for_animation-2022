using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
   [Header("Player movement")]
    public float _moveSpeed;
    private Rigidbody2D rd;
    public Vector2 _direction;
    private Vector2 movement;
    private Vector2 mouseImput;
    public float _mouseSensitivty = 4.0f;

    [Header ("Player health")]
    public int _maxHP;
    public int _curHP;

    [Header("Player combat")]
    public float _attackRange;
    public float _attackRate;
    private float lastAttackTime;
    public int _damage;
    public LayerMask _enemylayer;

    [Header("Inventroy")]
    public int _key;
    public int _coins; 
    public int _ammon;

    [Header("Sound Effects")]
    public AudioSource _source;
    public AudioClip _maker;

    [Header("Scripts")]
    public HealthBar _hpBar; // finds health bar from game assets
    public int _sceneToLoad;

    void Start()
    {

        rd = GetComponent<Rigidbody2D>();
        _curHP = _maxHP;
        _hpBar.SetHealth(_maxHP);

    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // get unity inbuilt movment setteing to move player
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            //if(Time.time - lastAttackTime >= attackRange)
            {}
                Attack();
                Debug.Log("Attack works");
                _source.PlayOneShot(_maker, 1.0f);
            
        }
        if(Input.GetKeyDown(KeyCode.C))
        // changes the screen rotaion
        {
            transform.rotation =  Quaternion.Euler(0,180,0);    
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            //sets screen rotaion to defult
            transform.rotation = Quaternion.Euler(0,0,0);
        }

    }

    void FixedUpdate()
    {
        
        rd.MovePosition(rd.position + movement * _moveSpeed * Time.deltaTime);
        UpdateDirection();

    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x, movement.y);

        if(vel.magnitude !=0)
        {
            _direction = vel;
        }
        rd.velocity = vel * _moveSpeed;

    }

        void Attack()
    {
        // set attack timer 
        lastAttackTime = Time.time;

        // finds and sets enemy layer to attack
        RaycastHit2D hit = Physics2D.Raycast(transform.position, _direction, _attackRange, _enemylayer);

        if(hit.collider != null)
        {
            // if the ray casting find the enmey then they take damge
            hit.collider.GetComponent<Enemy_Controller>()?.TakeDamage(_damage);
        }
    }

    void Die()
    {

        Debug.Log("You have died");
        SceneManager.LoadScene(_sceneToLoad);

    }

    public void TakeDamage(int _damage)
    {
        _curHP -= _damage
        -_hpBar.SetHealth(_curHP);

        if(_curHP <= 0)
        {
            Die();
        }
    }
}