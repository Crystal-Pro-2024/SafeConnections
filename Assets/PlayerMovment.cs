using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool IsGrounded;
    public float speed = 5f;
    public float RunSpeed = 15f;
    public float WalkSpeed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = controller.isGrounded;


    }

    public void Jump()
    {
        if (IsGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);


        }

    }




    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        audioSource.Play();




        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;


        if (IsGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;


        }
        controller.Move(playerVelocity * Time.deltaTime);






    }

    public void Sprint(InputAction.CallbackContext context)
    {


        if (context.performed) // the key has been pressed
        {
            speed = RunSpeed;
        }
        if (context.canceled) //the key has been released
        {
            speed = WalkSpeed;
        }


    }



}