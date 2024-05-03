using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEventSystem : MonoBehaviour
{
    private static MyEventSystem instance;

    public static MyEventSystem Instance
    {
        get {return instance ??= new MyEventSystem();}
    }
    private Dictionary<string , List<IListener>> simpleEvents;
    public void addListener(IListener newListener){}
    public void RemoveListener(IListener listener){}
    public void RaiseEvent(string eventToRaise){}
}
