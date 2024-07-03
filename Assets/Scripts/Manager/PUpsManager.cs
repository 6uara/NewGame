using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUpsManager : MonoBehaviour
{
    private static PUpsManager _instance;

    public event Action spawn;



    public static PUpsManager Instance  
    { 
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PUpsManager>(); 
                if (_instance == null)
                {
                    Debug.LogError("PUpsManager instance not found in the scene!");
                }
            }
            return _instance;
        }
    }


    public void SpawnPowerUp(){spawn?.Invoke();}
}
