using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyObject", menuName = "Enemy Info")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] private int SpherePoints;
    [SerializeField] private int SphereDamage;
    [SerializeField] private int SmallSpherePoints;
    [SerializeField] private int SmallSphereDamage;
    [SerializeField] private int BigSpherePoints;
    [SerializeField] private int BigSphereDamage;
    [SerializeField] private int ExplosivePoints;
    [SerializeField] private int ExplosiveDamage;
    [SerializeField] private int SpecialPoints;
    [SerializeField] private int SlowSphereDamage;
    [SerializeField] private int FastSphereDamage;

    public int spherePoints => SpherePoints;
    public int sphereDamage => SphereDamage;
    public int smallspherePoints => SmallSpherePoints;
    public int smallsphereDamage => SmallSphereDamage;
    public int bigspherePoints => BigSpherePoints;
    public int bigsphereDamage => BigSphereDamage;
    public int explosivePoints => ExplosivePoints;
    public int explosiveDamage => ExplosiveDamage;
    public int specialPoints => SpecialPoints;
    public int slowSphereDamage => SlowSphereDamage;
    public int fastSphereDamage => FastSphereDamage;
}
