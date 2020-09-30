using System;
using System.Collections;
using UnityEngine;

public class CharacterKnockBack : MonoBehaviour
{
    //Direction of the hit
    
    public CharacterController controller;
    public Vector3 knockBackVector;
    public float knockBackForce = 50f;
    private float tempForce;
    private void Start()
    {
        tempForce = knockBackForce;
    }
    
    private IEnumerator OnTriggerEnter()
    {
        while (knockBackForce > 0)
        {
            knockBackVector.x = knockBackForce * Time.deltaTime;
            controller.Move(knockBackVector);
            knockBackForce -= 0.1f;
            yield return new WaitForFixedUpdate();
        }
    }
}
