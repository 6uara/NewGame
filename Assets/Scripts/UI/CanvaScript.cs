using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvaScript : MonoBehaviour,IListener
{
    [SerializeField] private TMP_Text Time;
    [SerializeField] private TMP_Text Damage;
    [SerializeField] private TMP_Text Points;
    [SerializeField] private TMP_Text Coins;
   
    void Awake() 
    {
        UIManager.Instance.Eventos += UpdateUI;
        UIManager.Instance.final += setfalse; 
    }

    public void UpdateUI() 
    {
        UpdatePoints();
        UpdateDamage();
        UpdateCoins();
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

    public void setfalse(){gameObject.SetActive(false);}
    public void settrue(){gameObject.SetActive(true);}
    private void UpdateCoins()
    {
        Coins.text = "Coins: "+ LevelManager.Instance.coins;
    }
}
