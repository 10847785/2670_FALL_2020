using System;
using System.Collections;
using UnityEngine;

public class CharacterKnockBack : MonoBehaviour
{
    //Direction of the hit
    
    public CharacterController controller;
    private Vector3 move = Vector3.zero;
    public Vector3 knockBackVector;
    public float knockBackForce = 50f;
    private float tempForce;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        tempForce = knockBackForce;
    }

    private void Update()
    {
        controller.Move(move * Time.deltaTime);
    }

    private float pushPower = 10.0f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       // StartCoroutine(knockBack(hit));
       var body = hit.collider.attachedRigidbody;

       if (body == null || body.isKinematic)
       {
           return;
       }

       if (hit.moveDirection.y < -0.3)
       {
           return;
       }
       
       StartCoroutine(knockBack(hit));
       
       var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
      // body.velocity = pushDir * pushPower;
       var forces = pushDir * pushPower;
       body.AddRelativeForce(forces);
       body.AddTorque(forces);
    }

    private IEnumerator KnockBack(ControllerColliderHit hit)
    {
        var i = 2f;
        move = hit.collider.attachedRigidbody.velocity * i;
        while (i > 0)
        {
            knockBackVector.x = knockBackForce * Time.deltaTime;
            controller.Move(knockBackVector);
            knockBackForce -= 0.1f;
            yield return new WaitForFixedUpdate();
        }
    }
}
