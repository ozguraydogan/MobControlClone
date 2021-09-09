using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SoldierCounter : MonoBehaviour
{
    private bool isTrue;
    public GameObject soldier;
    private void OnTriggerEnter(Collider other)
    {
        isTrue = true;
        if (other.gameObject.CompareTag("wall2x") && isTrue)
        {
            for (int i = 0; i < 2; i++)
            {
                Instantiate(soldier, new Vector3(this.transform.position.x+Random.Range(0.2f,0.3f),this.transform.position.y,this.transform.position.z+Random.Range(0.5f,0.8f)), Quaternion.identity);
            }
        }
        if (other.gameObject.CompareTag("wall+10") && isTrue)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(soldier, new Vector3(this.transform.position.x+Random.Range(0.2f,0.3f),this.transform.position.y,this.transform.position.z+Random.Range(0.5f,0.8f)), Quaternion.identity);
            }
            other.gameObject.GetComponent<Collider>().enabled = false;
        }

        isTrue = false;
    }
    private void OnTriggerExit(Collider other)
    {
        isTrue = false;
    }
}
