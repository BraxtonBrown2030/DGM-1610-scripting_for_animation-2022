using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        //difining the player and what the projectile needs to targets
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        // geting the postion of the player and where the player use to be to set a path for the projectile
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    // this is swetting up a triger for hitting another object and deleting it on contrat to avoid memenry useinag and cludder 
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            DestroyProjectile();
        }
    }
    // destory projectiale so we can other effects such as effect and spawning more projectials 
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
