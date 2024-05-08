using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveSphere : MonoBehaviour,ISpheres
{   
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int points;
    [SerializeField] private int damage;
    private void Start() {}
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("Player Catched");
            LevelManager.Instance.UpdatePoints(points);
            SphereAction();
        }else{
            Debug.Log("Crashed");
            //lvlManager.UpdateDamage(damage);
        }
        Die();
    }

    private void SphereAction(){LevelManager.Instance.UpdateDamage(damage + 10);}
    public void Die(){Destroy(gameObject);}
}
