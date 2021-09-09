using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour
{
    public GameObject agent;
    public GameObject targetObj;
    public Transform firePoint;
    private bool isTrue;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTrue = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isTrue = false;
        }
    }

    private void FixedUpdate()
    { 
        if (isTrue)
        {
            StartCoroutine("SpawnAgent");
        }
    }

    private IEnumerator SpawnAgent()
    {
        GameObject soldier = (GameObject) Instantiate(agent, firePoint.position, Quaternion.identity);
        soldier.GetComponent<SoldierAI>().target = targetObj.transform;
        yield return new WaitForSeconds(10000*Time.deltaTime);
    }
}
