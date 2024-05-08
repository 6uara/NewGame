using UnityEngine;

public class SphereSpawner:AbstractFactory
{
    [SerializeField]private PrefabScriptable spherePrefab;
    public override GameObject CreateProduct(PTypes types)
    {

        switch(types)
        {
            case PTypes.Normal:
                return spherePrefab.normalSphere;
            case PTypes.Big:
                return spherePrefab.bigSphere;
            case PTypes.Small:
                return spherePrefab.smallSphere;
            case PTypes.TimeFast:
                return spherePrefab.fastSphere;
            case PTypes.TimeSlow:
                return spherePrefab.slowSphere;
            case PTypes.Explosive:
                return spherePrefab.explosiveSphere;
        }   

        return null;  
    }

    public void setSpawner(PrefabScriptable pfscr)
    {
        spherePrefab = pfscr;
    }
}