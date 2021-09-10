using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    public int enemyHealth;
    public Text enemyHealthText;
    public GameObject levelComplateUI;
    public GameObject gameOverUI;
    private void Start()
    {
        enemyHealth = 50;
        levelManager = this;
    }
    public void EnemyHealthDecrease()
    {
        enemyHealth--;
        enemyHealthText.text = enemyHealth.ToString();
        if (enemyHealth <= 0)
        {
            Camera.main.transform.parent = null;
            levelComplateUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void RetryButton()
    {
        GameManager.Manager.LevelCompleted();
    }

    public void NextLevelButton()
    {
        GameManager.Manager.LevelRetry();
    }

}