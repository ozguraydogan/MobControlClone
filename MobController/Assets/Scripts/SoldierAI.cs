using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierAI : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    public Transform target;
   void Start()
    {
        _navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
        _navMeshAgent.destination = target.position;
    }
}
