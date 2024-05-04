using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSphere : MonoBehaviour,ISpheres
{   
    [SerializeField]private PTypes type { get; }
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int points;
    [SerializeField] private float speed;
    [SerializeField] private LevelManager lvlManager;
    [SerializeField] private int damage;
    private void Start() {}
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("Player Catched");
            lvlManager.UpdatePoints(points);
            SphereAction();
        }else{
            Debug.Log("Crashed");
            lvlManager.UpdateDamage(damage);
        }
        Die();
    }

    private void SphereAction(){lvlManager.SlowTime();}
    public void Die(){Destroy(gameObject);}
}
