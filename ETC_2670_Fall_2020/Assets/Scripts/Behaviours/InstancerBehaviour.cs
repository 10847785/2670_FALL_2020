using System;
using UnityEngine;


public class InstancerBehaviour : MonoBehaviour
{
    public GameObject prefab;

    public Vector3Data rotationDirection;
    //Make a method to call the Instance Method

    public void Instance()
    {
        var location = transform.position;
        Instantiate(prefab,location, Quaternion.Euler(rotationDirection.value));
    }
}
