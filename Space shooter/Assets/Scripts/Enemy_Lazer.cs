using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Enemy_Lazer : MonoBehaviour
{
    [SerializeField]
    private float _LazerSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.down *_LazerSpeed * Time.deltaTime);

        if(transform.position.y > -8f)
        {
            Destroy(gameObject);
        }
    }
}
