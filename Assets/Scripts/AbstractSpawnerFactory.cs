using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSpawnerFactory 
{
    public abstract GameObject CreateObject(ProjTypes type);
}



