using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    private float xInput;
    private float zInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessInputs();
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }

    private void Jump()
    {   
        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0f, 6f), ForceMode.Impulse);
        }
    } 
}
