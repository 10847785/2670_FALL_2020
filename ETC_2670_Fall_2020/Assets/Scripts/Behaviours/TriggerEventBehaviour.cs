﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent;
    public float delayTime = 1f;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(delayTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(delayTime);
        TriggerEnterEvent.Invoke();
    }
}