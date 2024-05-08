using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public abstract class Sphere : MonoBehaviour,ISpheres
{   
    [SerializeField] public PTypes type;
    [SerializeField] public int points;
    [SerializeField] public int damage;
    [SerializeField]public EnemyScriptableObject EnemyInfo;
    public virtual void Start()
    {
        points = EnemyInfo.spherePoints;
        damage = EnemyInfo.sphereDamage;
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("Player Catched");
            Debug.Log(points);
            LevelManager.Instance.UpdatePoints(points);
            SphereAction();
        }else{
            Debug.Log("Crashed");
            LevelManager.Instance.UpdateDamage(damage);
        }
        Die();
    }

    public virtual void SphereAction(){}
    public virtual void Die(){Destroy(gameObject);}
}
