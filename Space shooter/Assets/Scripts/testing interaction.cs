using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class testinginteraction : MonoBehaviour
{
    
    public UnityEvent onEvent;

    void Start()
    {
        onEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        onEvent.Invoke();
    }
}
