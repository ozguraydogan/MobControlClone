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
            InvokeRepeating("Spawn",0,0.5f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("Spawn");
        }
    }

    void Spawn()
    {
        StartCoroutine("SpawnAgent");
    }
    private IEnumerator SpawnAgent()
    {
        GameObject soldier = (GameObject) Instantiate(agent , firePoint.position, Quaternion.identity);
        soldier.transform.parent = this.transform.parent;
        soldier.GetComponent<SoldierAI>().target = targetObj.transform;
        yield return new WaitForSeconds(0.5f);
    }
}
