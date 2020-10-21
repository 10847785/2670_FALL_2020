﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public int counter = 100;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs = new WaitForSeconds(1f);

    private IEnumerator Start()
    {
        
        while (counter > 0)
        {
            yield return new WaitForFixedUpdate();
            transform.Translate(0.1f, 0,0);
            counter--;
        }
        
     //   yield return new wfs(1);
        
        while (counter < 100)
        {
            yield return new WaitForFixedUpdate();
            transform.Translate(-0.1f, 0,0);
            counter++;
        }
        
       // yield return new wfs;

        StartCoroutine(Start());
    }
}