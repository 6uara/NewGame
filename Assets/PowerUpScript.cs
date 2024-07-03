using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour,IDestroy
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Character component = other.GetComponent<Character>();
            component.GetBigger();
        }
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
