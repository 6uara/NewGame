using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int points{get;set;}
    public int damage{get;set;}
    public float time{get;set;}


    private static LevelManager _instance; // Private static instance

    public static LevelManager Instance  // Public getter method
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<LevelManager>(); // Find the LevelManager object in the scene
                if (_instance == null)
                {
                    Debug.LogError("LevelManager instance not found in the scene!");
                }
            }
            return _instance;
        }
    }

    // Your other LevelManager properties and methods...

    void Awake() // Use Awake instead of Start to ensure instance is set up before other scripts access it
    {
        if (_instance != null && _instance != this) // Check for duplicate instances
        {
            Destroy(gameObject); // Destroy this instance if another LevelManager exists
            return;
        }

        _instance = this; // Set the static instance
    }

    private void Start()
    {
        points = 0;
        damage = 0;
        time = 300 / 60 ;
    }

    private void Update() 
    {
        time -=   Time.deltaTime / 60;
        
    }
    public void UpdateDamage(int daño)
    {
        damage += daño;
        Debug.Log("Damage Updated");
    }
    public void UpdatePoints(int puntos)
    {
        points += puntos;
        Debug.Log("Points Updated");
        if(points> 200)
        {
            FastTime();
        }
        if(points > 500)
        {
            FastTime();
        }
    }

    public void SlowTime(){Time.timeScale -= 0.2f;}
    public void FastTime(){Time.timeScale += 0.2f;}
}
