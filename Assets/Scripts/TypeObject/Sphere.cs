using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public abstract class Sphere : MonoBehaviour,ISpheres,IDestroy
{   
    [SerializeField] public PTypes type;
    [SerializeField] public int points;
    [SerializeField] public int damage;
    [SerializeField]public EnemyScriptableObject EnemyInfo;
    private SphereCollider sphereCollider;


    private Rigidbody rb;
    public virtual void Start()
    {
        points = EnemyInfo.spherePoints;
        damage = EnemyInfo.sphereDamage;
        rb = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    public virtual void SphereAction(){}
    public virtual void Die(){Destroy(gameObject);}

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player Catched");
            //Debug.Log(points);
            LevelManager.Instance.UpdatePoints(points);
            SphereAction();
        }
        Die();

    }
}
