using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public float force = 30f;

    public GameObject projectilePrefab;
    

    void Start()
    { 
        rBody = GetComponent<Rigidbody>();
       var forceDirection = new Vector3(force,0,0);
       //forceDirection needs to be based on Player rotation (hint ScriptableObject)
       rBody.AddRelativeForce(forceDirection);
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
        
    }
}
