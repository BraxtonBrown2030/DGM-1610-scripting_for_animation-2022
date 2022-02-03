using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    private  float speed = 20.0f;
    private float turnspeed = 50.0f;
    private float hImput;
    private float fImput;
    // Update is called once per frame
    void Update()
    {
      hImput = Input.GetAxis("Horizontal");
      fImput = Input.GetAxis("Vertical");

     // Translate(x,y,z) - Makes the player move forward // Time.DeltaTime make use of seconds and the * after control the speed or a variuble 
     transform.Translate(Vector3.forward * Time.deltaTime * speed * fImput);
     transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * hImput);

    }
}
