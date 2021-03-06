﻿using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
   // public GameAction getTransformAction, callForTransformAction;
   private bool canNav;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
       // getTransformAction.transformAction += HandleTransform;
       //callForTransformAction.action.Invoke();
    }

    private void HandleTransform(Transform obj)
    {
        if (canNav)
        {
            destination = obj;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other);
        if (other.transform == destination)
        {
            canNav = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
}
