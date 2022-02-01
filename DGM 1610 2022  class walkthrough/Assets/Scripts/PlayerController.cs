using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    public  float speed = 20.0f;
    public float turnspeed = 50.0f;

    public float hImput;
    public float fImput;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
      hImput = Input.GetAxis("Horizontal");

      fImput = Input.GetAxis("Vertical");

     // Translate(x,y,z) - Makes the player move forward // Time.DeltaTime make use of seconds and the * after control the speed or a variuble 
     transform.Translate(Vector3.forward * Time.deltaTime * speed * fImput);

     transform.Translate(Vector3.right * Time.deltaTime * turnspeed * hImput);

    }
}
