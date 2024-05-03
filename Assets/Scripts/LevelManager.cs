using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int points {get ; set ;}
    [SerializeField] private int damage;
    [SerializeField] private float time;
    private void Start()
    {
        points = 0;
        damage = 0;
        time = 600;
    }

    private void Update() 
    {

    }
    public void UpdateDamage(int daño)
    {
        damage += daño;
    }
    public void UpdatePoints(int puntos)
    {
        points += puntos;
    }

    public void SlowTime(){Time.timeScale = 0.8f;}
    public void FastTime(){Time.timeScale = 1.2f;}
}
