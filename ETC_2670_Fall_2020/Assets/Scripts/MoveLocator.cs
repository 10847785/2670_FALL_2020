using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocator : MonoBehaviour
{
    private Camera cam;
    public Transform pointObj;

    private void Start()
    {
        cam = Camera.main;
    }

    public void Move()
    {
        //taken from source code, but modified, might need to check later
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out var hit, 100))
        {
            pointObj.position = hit.point;
        }
    }
}
