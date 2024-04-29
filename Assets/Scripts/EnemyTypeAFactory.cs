using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;



public class EnemyTypeAFactory : AbstractSpawnerFactory
{ 
    [SerializeField] GameObject[] availableSpheres {get;}


    private Dictionary<ProjTypes, GameObject> ProjToSpawn = new Dictionary<ProjTypes, GameObject>();

    void Awake()
    {
        ProjToSpawn.Add(ProjTypes.Normal , availableSpheres[0]);
        ProjToSpawn.Add(ProjTypes.Small , availableSpheres[1]);
        ProjToSpawn.Add(ProjTypes.Big , availableSpheres[2]);
        ProjToSpawn.Add(ProjTypes.TimeFast , availableSpheres[3]);
        ProjToSpawn.Add(ProjTypes.TimeSlow , availableSpheres[4]);
        ProjToSpawn.Add(ProjTypes.Explosive , availableSpheres[5]);

    }

    public override GameObject CreateObject(ProjTypes type)
    {
        if (ProjToSpawn.TryGetValue(type, out GameObject prefab))
        {
            if (prefab.GetComponent<IProjectile>() != null) 
            {
                return prefab;
            }
            else
            {
                Debug.LogError("Retrieved prefab does not have IProjectile component!");
                // Handle the case where the prefab is not set up correctly
            }
        }
        else
        {
            Debug.LogError("Sphere type not found: " + type);
            // Throw an exception or return a default prefab
            // throw new System.Exception("Sphere type not found"); 
        }

        return null; // Or a default prefab
    }

}

public enum ProjTypes
{
    Normal,
    Small,
    Big,
    Explosive,
    TimeSlow,
    TimeFast
}