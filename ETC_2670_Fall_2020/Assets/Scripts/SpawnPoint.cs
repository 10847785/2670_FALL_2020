using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data vData;
    
    // Set the vData from the position value
    
    
    private void OnParticleTrigger(Collider other)
    {
        // Set the location data of the player to the current spawnPoint
        transform.TransformVector(0, 0, 0);
    }
}
