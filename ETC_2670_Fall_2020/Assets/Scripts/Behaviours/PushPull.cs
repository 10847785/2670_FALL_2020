using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    public float push = 10f;
    void Update()
    {
        if (Input.GetKeyDown(0))
        {
            GetComponent<Rigidbody>().AddForce(force: transform.forward * -1f * push);
        }
    }
    
}
