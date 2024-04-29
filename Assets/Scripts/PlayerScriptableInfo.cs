using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptableInfo : ScriptableObject
{
    [SerializeField] private float baseplayerSpeed { get;  }
    [SerializeField] private int baseplayerHealth  { get;  }
    [SerializeField] private float playerSpeedAccelerated { get;  }
    [SerializeField] private float playerSpeedSlowed  { get;  }
    [SerializeField] private int playerHealthlvlup  { get;  }
    [SerializeField] private int playerHealthlvlup2  { get;  }


}
    

