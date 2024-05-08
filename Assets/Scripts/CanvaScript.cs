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
    // Start is called before the first frame update
    void Start()
    {
        //lvlManager.OnPointsUpdate += updatePoints;// deberia ser el lvl manager, no el Pj
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
        UpdatePoints();
        UpdateDamage();
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
}
