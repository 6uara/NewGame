using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExplosiveSphere : Sphere,ISpheres
{  
    public override void Start()
    {
        points = EnemyInfo.explosivePoints;
        damage = EnemyInfo.explosiveDamage;
    }
    public override void OnTriggerEnter(Collider other) 
    {
        base.OnTriggerEnter(other);
    }
    public override void SphereAction()
    {
        base.SphereAction();
    }
    public override void Die()
    {
        base.Die();
    }
}
