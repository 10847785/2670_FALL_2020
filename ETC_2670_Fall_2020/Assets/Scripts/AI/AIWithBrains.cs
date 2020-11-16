using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
//[RequireComponent(typeof())]
public class AIWithBrains : MonoBehaviour
{
    public AIBrainBase aiBrain;
    public Transform player;
    private int i;
    public List<AIBrainBase> brainUpgrades;

    private MeshFilter filter;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        filter = GetComponent<MeshFilter>();
        filter.mesh = aiBrain.art;
    }

    private void Update()
    {
        aiBrain.Navigate(agent);
    }

    private void OnTriggerEnter(Collider other)
    {
        aiBrain = brainUpgrades[i];
        filter.mesh = aiBrain.art;

        if (i < brainUpgrades.Count)
        {
            i++;
        }
    }
}
