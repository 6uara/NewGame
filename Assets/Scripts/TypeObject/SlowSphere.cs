using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlowSphere : Sphere, ISpheres
{   
    public override void Start()
    {
        points = EnemyInfo.specialPoints;
        damage = EnemyInfo.slowSphereDamage;
    }
    public override void OnTriggerEnter(Collider other) {base.OnTriggerEnter(other);}
    public override void Die()
    {
        base.Die();
    }
    public override void SphereAction()
    {
        LevelManager.Instance.SlowTime();
    }
}
