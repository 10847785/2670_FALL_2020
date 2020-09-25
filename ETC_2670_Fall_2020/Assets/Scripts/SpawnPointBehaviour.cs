using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBehaviour : MonoBehaviour
{
    public Vector3Data vData;
    
    // Set the vData from the position value
  //  transform.position


  private void OnParticleTrigger(Collider other)
    {
        //vData.SetValueFromTransform(transform.position);
    }
}


