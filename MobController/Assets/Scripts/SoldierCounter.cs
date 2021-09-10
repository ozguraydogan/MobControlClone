using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
                GameObject clone =(GameObject)Instantiate(soldier, new Vector3(this.transform.position.x+Random.Range(0.2f,0.3f),this.transform.position.y,this.transform.position.z+Random.Range(0.5f,0.8f)), Quaternion.identity);
                clone.transform.parent = LevelManager.levelManager.transform;            }
        }
        if (other.gameObject.CompareTag("wall4x") && isTrue)
        {
            for (int i = 0; i < 4; i++)
            {
                GameObject clone =(GameObject)Instantiate(soldier, new Vector3(this.transform.position.x+Random.Range(0.2f,0.3f),this.transform.position.y,this.transform.position.z+Random.Range(0.5f,0.8f)), Quaternion.identity);
                clone.transform.parent = LevelManager.levelManager.transform;
            }
        }

        if (other.gameObject.CompareTag("enemy"))
        {
           Destroy(other.gameObject);
           Destroy(this.gameObject,0.1f);
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            LevelManager.levelManager.EnemyHealthDecrease();
        }
        isTrue = false;
    }
    private void OnTriggerExit(Collider other)
    {
        isTrue = false;
    }
}
