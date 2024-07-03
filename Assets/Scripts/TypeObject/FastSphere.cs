using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastSphere : Sphere,ISpheres
{    
    public override void Start()
    {
        points = EnemyInfo.specialPoints;
        damage = EnemyInfo.fastSphereDamage;
    }
    public override void OnTriggerEnter(Collider other) {base.OnTriggerEnter(other);}
    public override void SphereAction()
    {
        LevelManager.Instance.FastTime();
    }
    public override void Die()
    {
        base.Die();
    }
}
