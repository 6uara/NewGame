using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour,ICoin,IDestroy
{
    void OnTriggerEnter(Collider other)
    {
        GainGold();
        Die();
    }

    public void GainGold()
    {
        LevelManager.Instance.UpdateCoins(10);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
