using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> levels;
    private List<GameObject> insLevel;
    public static GameManager Manager;
    private GameObject start;
    private void Start()
    {
        start= Instantiate(levels[0]);
        insLevel.Add(start);
        Manager = this;
    }
    public void LevelCompleted(int counter)
    {
        //Level silinmeden önce kamera level in child i ise çıkartılacak
        Camera.main.transform.parent = null;
        Destroy(insLevel[0]);
        GameObject ins=Instantiate(levels[counter+1]);
        Time.timeScale = 1f;
        insLevel.Add(ins);
    }
    
    public void LevelRetry(int counter)
    {
        Destroy(insLevel[0]);
        insLevel.RemoveAt(0);
        GameObject ins=Instantiate(levels[counter]);
        Time.timeScale = 1f;
        insLevel.Add(ins);
    }
    
}
