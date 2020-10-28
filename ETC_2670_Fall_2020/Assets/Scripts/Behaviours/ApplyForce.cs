using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public Vector3 forces;

    public bool canRunOnStart;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        if (canRunOnStart)
        {
            OnApplyForce();
        }
    }

    public void OnApplyForce()
    {
        rBody.AddRelativeForce(forces);
    }

  /*  public GameObject projectilePrefab;
    

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
        
    } */
}
