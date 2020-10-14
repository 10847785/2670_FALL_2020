using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterBehaviour : MonoBehaviour
{
    public float rotateSpeed = 30f, gravity = -9.81f, jumpForce = 10f;
    public FloatData normalSpeed, fastSpeed;
    public IntData playerJumpCount;
    
    private float yVar;
    private FloatData moveSpeed;
    private int jumpCount;
    
    protected CharacterController controller;
    protected Vector3 movement;
    protected bool canMove = true;
    protected readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();

   private void Start()
   {
       moveSpeed = normalSpeed;
       controller = GetComponent<CharacterController>();
       StartCoroutine(Move());
       canMove = true;
       while (canMove)
       {
           //different Code
           OnRotate();
           OnMove();
           yield return wffu;
       }
   }

   private IEnumerator Move()
   {
       

   }

   protected virtual void OnRotate()
   {
       var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
       transform.Rotate(0, hInput, 0);
   }

   private void OnMove()
   {
       if (Input.GetKeyDown(KeyCode.LeftShift))
       {
           moveSpeed = fastSpeed;
       }

       if (Input.GetKeyUp(KeyCode.LeftShift))
       {
           moveSpeed = normalSpeed;
       }

       var vInput = Input.GetAxis("Vertical") * moveSpeed.value;
       movement.Set(vInput, yVar, 0);

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
}
