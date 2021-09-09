using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyAI : MonoBehaviour
{
    public GameObject agent;
    public Transform targetObj;
    public Transform firePoint;
    private bool isTrue;

    private void Start()
    {
        Invoke("EnemySpawn",2);
    }

    private void FixedUpdate()
    { 
        if (isTrue)
        {
            StartCoroutine("SpawnAgent");
        }
    }

    void EnemySpawn()
    {
        GameObject soldier = (GameObject) Instantiate(agent, firePoint.position, Quaternion.identity);
        soldier.GetComponent<SoldierAI>().target = targetObj;
        Invoke("EnemySpawn",Random.Range(0.5f,1f));
    }


}
