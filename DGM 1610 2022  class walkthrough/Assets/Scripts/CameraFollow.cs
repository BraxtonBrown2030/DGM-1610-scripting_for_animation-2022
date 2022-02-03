using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

// (0,0,0) is the offset of tyhe camera
    private Vector3 offset = new Vector3(0,2,-3);

    // Update is called once per frame
    void Update()
    {
        //follows the player
        transform.position = player.transform.position + offset;

    }
}
