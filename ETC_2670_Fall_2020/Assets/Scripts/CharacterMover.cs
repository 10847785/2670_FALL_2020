using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = -9.81f;
    public float moveSpeed = 3f;
    public float fastMoveSpeed;
    public float jumpForce = 10f;
    public int jumpCountMax;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal")*moveSpeed;
       // To us the GetKey function git rid of Input.GetAxis("Horizontal")*
     //   if (Input.GetKey(KeyCode.Y))
     //   {
     //       movement.x *= moveSpeed;
     //   }
        
        if (Input.GetButtonDown("Jump"))
        {
            movement.y = jumpForce;
        }

        if (controller.isGrounded)
        {
            movement.y = 0;
        }

        else
        {
            movement.y -= gravity;
        }
        
        controller.Move(movement*Time.deltaTime);
    }
}
