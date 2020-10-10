using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform playerBody;


    // physics 
    Vector3 velocity;
    private int moveSpeed = 12;
    private int turnSpeed = 200;
    private float jumpHeight = 0.03f;
    private float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;
    public LayerMask deathMask;
    bool isGrounded;
    bool isDead;

    // Update is called once per frame
    void Update()
    {
        // check to see if ground is within a spherical checked area
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // apply gravity
        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime * Time.deltaTime;
        }
        else
        {
            velocity.y = 0;
        }

        // apply jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y += jumpHeight;
        }

        controller.Move(velocity);


        // forward/backwards W/S movement
        controller.Move(transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        // left/right A/D turning
        playerBody.Rotate(transform.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime);

    }
}
