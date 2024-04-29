using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaFakinFactory : MonoBehaviour
{
    public GameObject spherePrefab; // Assign your Sphere prefab in the Inspector
    public float spawnInterval = 5.0f; // Set the spawn interval to 5 seconds
    [SerializeField] private GameObject[] SpawnPoints;

    private float timer;
    public void Produce(){
        var sSpawner = new SphereSpawner();
        Sphere newSphere = (Sphere)sSpawner.CreateProduct(PTypes.Normal);
        int indexNumber = Random.Range(0, 5);  
        // Instantiate the prefab instead of the Sphere class directly
        GameObject sphereInstance = Instantiate(spherePrefab, SpawnPoints[indexNumber].transform.position, transform.rotation);
    }

    private void Update() {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Produce();
            timer = 0; // Reset the timer
        }
    }
}


