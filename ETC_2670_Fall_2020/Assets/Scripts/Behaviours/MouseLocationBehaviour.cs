using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocationBehaviour : MonoBehaviour
{
    private Camera cam;
    public Vector3Data locationData;
    private void Start()
    {
        cam = Camera.main;
    }
}
