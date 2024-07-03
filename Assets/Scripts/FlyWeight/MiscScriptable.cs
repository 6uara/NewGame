using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MiscellaneusInfo", menuName = "MiscellaneusInfo")]
public class MiscScriptable : ScriptableObject
{
    [SerializeField]private float PlayerSpeed;
    [SerializeField]private int CoinValue;
    [SerializeField]private Vector3 BiggerDimensions;
    [SerializeField]private int PowerTimer;


    public float speed => PlayerSpeed;
    public int coinvalue => CoinValue;
    public Vector3 biggerdimensions => BiggerDimensions;
    public int powertimer => PowerTimer;
}
