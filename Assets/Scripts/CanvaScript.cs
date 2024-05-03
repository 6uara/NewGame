using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvaScript : MonoBehaviour
{
    [SerializeField] private LevelManager lvlManager; //deberia ser el lvl manager, no el pj
    [SerializeField] private GameObject Time;
    [SerializeField] private GameObject Damage;
    [SerializeField] private GameObject Points;
    // Start is called before the first frame update
    void Start()
    {
        //lvlManager.OnPointsUpdate += updatePoints;// deberia ser el lvl manager, no el Pj
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void updatePoints(){}
    public void updateTime(){}
    public void updateDamage(){}
}
