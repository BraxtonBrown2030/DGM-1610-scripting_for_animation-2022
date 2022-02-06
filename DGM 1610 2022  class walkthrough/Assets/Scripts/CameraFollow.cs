using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

// (0,0,0) is the offset of the camera relative to the target object (Player)
    private Vector3 offset = new Vector3(0,2,-3);

    void Update()
    {
        //follows the target object (player)
        transform.position = player.transform.position + offset;

    }
}
