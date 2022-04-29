using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Transform playerRoot;
    

    public float walkSpeed;
    public float sprintSpeed;
    public float currentSpeed;

    public float gravity = -9.8f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 3f;

    public float playerWidth;
    public float playerCurrentHeight;
    public float playerDefaultHeight;
    public float playerCrouchHeight;
    public float crouchSpeed;

   

    public KeyCode sprintKeyCode;
    public KeyCode jumpKeyCode;
    public KeyCode crouchKeyCode;

   
    public LayerMask groundMask;
   
    Vector3 velocity;

    bool isGrounded;
    public bool isSprinting = false;
    public bool crouching;
  

      
   

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance,groundMask);

       

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward *z;

        controller.Move(move * currentSpeed * Time.deltaTime);

        // Jump
        if(Input.GetKey(jumpKeyCode) && isGrounded && crouching == false)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        // Sprint
        if (Input.GetKey(sprintKeyCode))
        {
            currentSpeed = sprintSpeed;
            
        }
        else
        {
            currentSpeed = walkSpeed;
            
        }

        // Crouch
        if (Input.GetKey(crouchKeyCode)&& isGrounded == true)
        {
            playerCurrentHeight = Mathf.Lerp(playerCurrentHeight, playerCrouchHeight, crouchSpeed * Time.deltaTime);
            playerRoot.localScale = new Vector3(playerWidth, playerCurrentHeight, playerWidth);
            crouching = true;
        }
        else
        {
            playerCurrentHeight = Mathf.Lerp(playerCurrentHeight, playerDefaultHeight, currentSpeed * Time.deltaTime);
            playerRoot.localScale = new Vector3(playerWidth, playerCurrentHeight, playerWidth);
            crouching = false;

        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

       
    }
}
