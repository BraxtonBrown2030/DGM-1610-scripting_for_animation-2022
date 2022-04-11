using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    private Rigidbody rb;
    private Vector3 moveImput;
    private Vector2 houseImput;
    private  Vector2 mouseImput;
    public float mouseSensitivty = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Hide and lock cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        moveImput = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
        Vector3 moveH = transform.right * moveImput.x;
        Vector3 moveV = transform.forward * moveImput.z;
        rb.velocity = (moveH + moveV) * movespeed;

        mouseImput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivty;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseImput.x, transform.rotation.eulerAngles.z);
    }
}
