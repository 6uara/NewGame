using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour,ICoin,IDestroy
{
    [SerializeField] private MiscScriptable miscInfo;
    void OnTriggerEnter(Collider other)
    {
        GainGold();
        Die();
    }

    public void GainGold()
    {
        LevelManager.Instance.UpdateCoins(miscInfo.coinvalue);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
