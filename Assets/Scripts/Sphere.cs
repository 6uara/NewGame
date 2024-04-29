using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour,IProjectile
{   
    [SerializeField]private ProjTypes type { get; }
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

    private void Start() {
        if (type == ProjTypes.Big)
        {
            transform.localScale = new Vector3(2,2,2);
        }
        if (type == ProjTypes.Small)
        {
            transform.localScale = new Vector3((float)0.5,(float)0.5,(float)0.5);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("Player Catched");
            if (type == ProjTypes.TimeSlow){}
            if (type == ProjTypes.TimeFast){}
        }else{
            Debug.Log("Crashed");
        }
        Destroy(gameObject);
    }

}
