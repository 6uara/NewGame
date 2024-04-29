using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] Projectiles;
    [SerializeField]private float spawnRate;
    [SerializeField]private EnemyTypeAFactory factory;


    private void Start() 
    {
        Debug.Log("Started");
        var factory = new EnemyTypeAFactory();
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {   
        Debug.Log("Started Coroutine");
        GameObject asd = factory.CreateObject(ProjTypes.Normal);
        if (asd == null){
            print("Sphere is null");
        }else{
            Instantiate(asd);
            asd.transform.position = transform.position;
            print("Instanciado");
        }
        yield return new WaitForSeconds(spawnRate);
        
    }
}
