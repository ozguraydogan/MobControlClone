using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    public int enemyHealth;
    public Text enemyHealthText;
    private void Start()
    {
        enemyHealth = 50;
        levelManager = this;
    }
    public void EnemyHealthDecrease()
    {
        enemyHealth--;
        enemyHealthText.text = enemyHealth.ToString();
    }

    public void GameOver()
    {
        // UI aktif edilecek oyun durdurulacak.
        Debug.Log("Game Over");
    }

}