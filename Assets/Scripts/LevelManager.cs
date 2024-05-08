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


    public event Action Eventos;

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
        {}
    }
    public void UpdateDamage(int daño)
    {
        damage += daño;
        Eventos?.Invoke();
        Debug.Log("Damage Updated");
    }
    public void UpdatePoints(int puntos)
    {
        points += puntos;
        Eventos?.Invoke();
        Debug.Log("Points Updated");
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
