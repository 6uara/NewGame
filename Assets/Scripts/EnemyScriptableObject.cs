using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "Player Info")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] private int SpherePoints{get;}
    [SerializeField] private float SphereDamage{get;}
    [SerializeField] private int ExplosivePoints{get;}
    [SerializeField] private float ExplosiveDamage{get;}
    [SerializeField] private int SpecialPoints{get;}
    [SerializeField] private int BigSphereDamage{get;}
    [SerializeField] private int SmallSphereDamage{get;}
}
