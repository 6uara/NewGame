using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvaScript : MonoBehaviour
{
    [SerializeField] private TMP_Text Time;
    [SerializeField] private TMP_Text Damage;
    [SerializeField] private TMP_Text Points;
   
    void Awake() 
    {
        LevelManager.Instance.Eventos += UpdateUI;
        LevelManager.Instance.final += setfalse; 
    }

    public void UpdateUI() 
    {
        UpdatePoints();
        UpdateDamage();
    }

    private void Update()
    {
        UpdateTime();
    }


    public void UpdatePoints()
    {
        Points.text = "Points "+LevelManager.Instance.points.ToString();
    }
    public void UpdateTime()
    {
        Time.text = "Time "+ LevelManager.Instance.time.ToString();
    }
    public void UpdateDamage()
    {
        Damage.text = "Damage "+LevelManager.Instance.damage.ToString();
    }

    public void setfalse(){
        gameObject.SetActive(false);
    }
}
