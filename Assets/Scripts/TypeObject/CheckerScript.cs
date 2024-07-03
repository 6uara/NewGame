using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerScript : MonoBehaviour
{
    [SerializeField]public EnemyScriptableObject EnemyInfo;
    private int damage;
    public void Start()
    {
        damage = EnemyInfo.sphereDamage;
    }

    
    public void OnTriggerEnter(Collider other)
    {
        Sphere sphereComponent = other.GetComponent<Sphere>();
        if (sphereComponent != null)
        {
            LevelManager.Instance.UpdateDamage(sphereComponent.damage);
        }
    }

}