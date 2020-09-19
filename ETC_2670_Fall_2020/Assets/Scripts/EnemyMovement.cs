﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float movementRadius;
    private NavMeshAgent agent;

    public Transform target;

    public float moveTowards;

    public float alert;

    public float attack;
    private float distance;

    private Vector3 direction;
    
    //Attack Player
    public int damage;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }
    
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if (distance < alert && distance > attack)
        {
            moveTowards += 3;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveTowards * Time.deltaTime);
        }
        
        
    }
}
