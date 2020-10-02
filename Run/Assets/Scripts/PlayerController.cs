using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20;
    public float rotateSpeed = 30f;
    private Rigidbody rbody;
    public float normalSpeed, fastSpeed;
    private Vector3 movement;
   

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var horAxis = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0,horAxis,0);
        var vertAxis = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horAxis, 0, vertAxis) * moveSpeed * Time.deltaTime;
        
        rbody.MovePosition(transform.position + movement);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 50;
        }

        else
        {
            moveSpeed = 20;
        }
       
    }
}
