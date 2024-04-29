using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "Player Info")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] private float baseSphereSpeed { get;  }
    [SerializeField] private int baseSpherePoints  { get;  }
    [SerializeField] private float FriendlySphereDamage { get;  }
    [SerializeField] private float ExplosiveDamage  { get;  }
    [SerializeField] private int SpecialPoints  { get;  }
    [SerializeField] private int BigSphereSpeed  { get;  }
    [SerializeField] private int SmallSphereSpeed  { get;  }
}
