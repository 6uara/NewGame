using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSpheres : Sphere,ISpheres
{
    public override void Start()
    {
        base.Start();
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
