using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 80f;
    public float highJump = 480f;
    public float mass = 30;

    public Transform groundCheck;
    public float groundDist = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    public bool highJ;
    private bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            if (highJ)
            {
                velocity.y = Mathf.Sqrt(highJump * -2f * gravity);
                highJ = false;
            }
            else
                velocity.y =  Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        
        velocity.y += mass * gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
