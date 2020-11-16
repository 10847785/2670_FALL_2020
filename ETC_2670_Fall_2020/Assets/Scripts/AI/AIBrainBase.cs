using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIBrainBase : ScriptableObject
{
    public float health;
    public float speed;
    public Mesh art;

    public virtual void Navigate(NavMeshAgent agent)
    {
        //destination
        //Make agents do different things
    }
    
}
