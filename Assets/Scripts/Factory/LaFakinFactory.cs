using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaFakinFactory : MonoBehaviour
{
    //[SerializeField]private PrefabScriptable spherePrefab; // esto es lo que tiene demas
    public float spawnInterval = 3.0f; 
    [SerializeField] private GameObject[] SpawnPoints;

    private PTypes type;
    private SphereSpawner sSpawner;

    private float timer;


    private void Awake() 
    {
        sSpawner = new SphereSpawner();
        //sSpawner.setSpawner(spherePrefab);
        UIManager.Instance.final += setfalse;
        PUpsManager.Instance.spawn += producepowerUp;
    }
    public void Produce(){
        type = (PTypes)Random.Range(0, 7);
        print(type);
        int indexNumber = Random.Range(0, 5); 
        var sphereInstance = sSpawner.CreateProduct(type);
        GameObject newSphere = Instantiate(sphereInstance,SpawnPoints[indexNumber].transform.position ,transform.rotation);
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

    public void producepowerUp()
    {
        type = (PTypes)7;
        int indexNumber = Random.Range(0, 5); 
        var sphereInstance = sSpawner.CreateProduct(type);
        GameObject newSphere = Instantiate(sphereInstance,SpawnPoints[indexNumber].transform.position ,transform.rotation );
    }
}


