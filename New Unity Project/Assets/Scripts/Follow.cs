using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed; // set how fact object can move
    public float stopDistance; // set how far current object and be form tagret object
    private Transform target; // set target object 
    void Start()
    {
        // regeester current player and target
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {  
        // find distance between two object and checks to see if curreent object needs to stop moveing
        if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
