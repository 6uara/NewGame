using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyPrefabs", menuName = "EnemyPrefabs")]
public class PrefabScriptable : ScriptableObject
{
    [SerializeField] private GameObject NormalSphere;
    [SerializeField] private GameObject BigSphere;
    [SerializeField] private GameObject SmallSphere;
    [SerializeField] private GameObject FastSphere;
    [SerializeField] private GameObject SlowSphere;
    [SerializeField] private GameObject ExplosiveSphere;


    public GameObject normalSphere => NormalSphere;
    public GameObject bigSphere => BigSphere;
    public GameObject smallSphere => SmallSphere;
    public GameObject fastSphere => FastSphere;
    public GameObject slowSphere => SlowSphere;
    public GameObject explosiveSphere => ExplosiveSphere;

}
