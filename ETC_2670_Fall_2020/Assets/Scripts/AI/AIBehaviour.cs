using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
   private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
   private NavMeshAgent agent;
   public Transform player;
   private bool canNav = true;

   private void Start()
   {
      agent = GetComponent<NavMeshAgent>();
   }

   private IEnumerator OnTriggerEnter(Collider other)
   {
      canNav = true;
      agent.destination = player.position;
      var distance = agent.remainingDistance;
      while (distance <= 0.25f)
      {
         distance = agent.remainingDistance;
         yield return wffu;
      }
      yield return new WaitForSeconds(2f);
      
      if (canNav)
      {
         StartCoroutine(OnTriggerEnter(other));
      }
   }

   private void OnTriggerExit(Collider other)
   {
      canNav = false;
   }
}
