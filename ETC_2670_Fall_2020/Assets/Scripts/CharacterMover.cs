using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
   private CharacterController controller;
   private Vector3 movement;

   public float rotateSpeed = 30f, gravity = -9.81f, jumpForce = 10f;
   private float yVar;

   public FloatData moveSpeed, normalSpeed, fastSpeed;

   public IntData playerJumpCount;
   private int jumpCount;
   public IntData playerSpawn, spawnLocate;

   public Vector3Data currentSpawnPoint;
   
   private void Start()
   {
      controller = GetComponent<CharacterController>();
   }
   private void Update()
   {

      if (Input.GetKeyDown(KeyCode.LeftShift))
      {
         moveSpeed = fastSpeed;
      }

      if (Input.GetKeyUp(KeyCode.LeftShift))
      {
         moveSpeed = normalSpeed;
      }
      
      var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
      movement.Set(vInput,yVar,0);

      var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
      transform.Rotate(0,hInput, 0);

      yVar += gravity * Time.deltaTime;

      if (controller.isGrounded && movement.y < 0)
      {
         yVar = -1f;
         jumpCount = 0;
      }

      if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
      {
         print(jumpCount);
         yVar = jumpForce;
         jumpCount++;
      }

      movement = transform.TransformDirection(movement);
      controller.Move(movement * Time.deltaTime);
   }
   

   private void OnEnable()
   {
      // Set the position of the player to the location data of the player
      playerSpawn.value = spawnLocate.value;
      
   }
}
