using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Other_ships_follow : MonoBehaviour
{
    public float _Speed;
    public float _StopDistince;
    private Transform target;
    void Start()
    {
        //find gameobject with player tag
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {
        // get distance and range between player and follower // set follower pos
        if(Vector2.Distance(transform.position, target.position) > _StopDistince)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, _Speed * Time.deltaTime);
        }

    }
}
