using System;
using UnityEngine;


public class InstancerBehaviour : MonoBehaviour
{
    public GameObject prefab;
    
    //Make a method to call the Instance Method

    public void Instance()
    {
        var location = transform.position;
        var var = Instantiate(prefab);
    }
}
