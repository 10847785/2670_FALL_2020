﻿using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
    public void OnLook(Vector3Data obj)
    {
        Transform transform1;
        (transform1 = transform).LookAt(obj.value);
        var transformRotation = transform.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        
    }
}
