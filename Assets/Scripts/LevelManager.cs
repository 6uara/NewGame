using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int points {get ; set ;}
    public int damage {get ; set ;}
    public float time {get ; set ;}

    private void Start()
    {
        points = 0;
        damage = 0;
        time = 600;
    }

    private void Update() 
    {
        time -= Time.deltaTime;
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
    }

    public void SlowTime(){Time.timeScale -= 0.2f;}
    public void FastTime(){Time.timeScale += 0.2f;}
}
