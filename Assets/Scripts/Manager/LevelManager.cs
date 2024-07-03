using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int points{get;set;}
    public int damage{get;set;}
    public float time{get;set;}
    private bool checkpoint1 = true;
    private bool checkpoint2 = true;
    private static LevelManager _instance; 
    public IListener canvasn;
    public int coins = 0;

    public static LevelManager Instance  
    { 
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<LevelManager>(); 
                if (_instance == null)
                {
                    Debug.LogError("LevelManager instance not found in the scene!");
                }
            }
            return _instance;
        }
    }


    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);  // Ensure that the LevelManager persists across scenes if needed
    }

    private void Start()
    {
        points = 0;
        damage = 0;
        time = 60 / 60 ;
    }

    private void Update() 
    {
        time -=   Time.deltaTime / 60;
        if(time <= 0)
        {
            UIManager.Instance.Fin();  
        }
    }
    public void UpdateDamage(int daño)
    {
        damage += daño;
        UIManager.Instance.Event();
        //Debug.Log("Damage Updated");
    }
    public void UpdateCoins(int monedas)
    {
        coins += monedas;
        UIManager.Instance.Event();
    }
    public void UpdatePoints(int puntos)
    {
        points += puntos;
        UIManager.Instance.Event();
        //Debug.Log("Points Updated");
        if(points> 200m && checkpoint1)
        {
            FastTime();
            checkpoint1 = false;
        }
        if(points > 500 && checkpoint2)
        {
            FastTime();
            checkpoint2 = false;
        }
    }

    public void SlowTime(){Time.timeScale -= 0.2f;}
    public void FastTime(){Time.timeScale += 0.2f;}
}
