using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Sphere : MonoBehaviour,ISpheres
{   
    [SerializeField]private PTypes type { get; }
    [SerializeField] private Rigidbody rb;
    [SerializeField] private int points;
    [SerializeField] private float speed;


    /*
    public Sphere(projTypes type){
        projTypes = type;
        if (type == projTypes.Big)
        {
            transform.localScale = new Vector3(2,2,2);
        }
        if (type == projTypes.Small)
        {
            transform.localScale = new Vector3((float)0.5,(float)0.5,(float)0.5);
        }
    }
    */
    public Sphere(string type){}
    private void Start() {}


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("Player Catched");
            if (type == PTypes.TimeSlow){}
            if (type == PTypes.TimeFast){}
        }else{
            Debug.Log("Crashed");
        }
        Destroy(gameObject);
    }

}
