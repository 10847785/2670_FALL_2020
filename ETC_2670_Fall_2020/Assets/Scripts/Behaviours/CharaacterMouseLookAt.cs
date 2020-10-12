using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaacterMouseLookAt : MonoBehaviour
{
    public Vector3Data mouseLocation;
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 30f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public FloatData normalSpeed, fastSpeed;
    private FloatData moveSpeed;
    private bool canMove = true;
    
    public IntData playerJumpCount;
    private int jumpCount;
  /*  void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(mouseLocation);
        var transformRotation = transform.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation); 
        
        yield return wffu;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
         
        var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
        movement.Set(vInput,yVar, 0);
        var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0, hInput, 0);

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
    } */
}
