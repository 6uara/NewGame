using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public event Action final;
    public event Action Eventos;


    public static UIManager Instance  
    { 
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UIManager>(); 
                if (_instance == null)
                {
                    Debug.LogError("LevelManager instance not found in the scene!");
                }
            }
            return _instance;
        }
    }


    public void Fin(){ final?.Invoke();}
    public void Event(){ Eventos?.Invoke();}
}
