using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaFakinFactory : MonoBehaviour
{
    [SerializeField]private PrefabScriptable spherePrefab; 
    public float spawnInterval = 5.0f; 
    [SerializeField] private GameObject[] SpawnPoints;

    private PTypes type;
    private SphereSpawner sSpawner;

    private float timer;


    private void Awake() 
    {
        sSpawner = new SphereSpawner();
        sSpawner.setSpawner(spherePrefab);
        LevelManager.Instance.final += setfalse;
    }
    public void Produce(){
        type = (PTypes)Random.Range(0, 6);
        int indexNumber = Random.Range(0, 5); 
        var sphereInstance = sSpawner.CreateProduct(type);
        GameObject newSphere = Instantiate(sphereInstance,SpawnPoints[indexNumber].transform.position ,transform.rotation );
    }

    private void Update() {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Produce();
            timer = 0; 
        }
    }

    public void setfalse()
    {
        gameObject.SetActive(false);
    }
}


