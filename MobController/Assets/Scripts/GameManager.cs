using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> levels;
    public List<GameObject> insLevel;
    public static GameManager Manager;
    private GameObject start;
    [SerializeField] private Vector3 cameraPosition;

    private void Start()
    {
        start= Instantiate(levels[0]);
        insLevel.Add(start);
        Manager = this;
    }

    private int scor;
    
    
    public void LevelCompleted(int counter)
    {
        Camera.main.transform.parent = null;
        Camera.main.transform.position = cameraPosition;
        Destroy(insLevel[0]);
        
        GameObject ins=Instantiate( levels[counter+1] );
        insLevel.Add(ins);
    }
    
    public void LevelRetry(int counter)
    {
        Destroy(insLevel[0]);
        insLevel.RemoveAt(0);
        GameObject ins=Instantiate(levels[counter]);
        insLevel.Add(ins);
    }
    
}
