using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishCanvasScript : MonoBehaviour
{
    [SerializeField] private TMP_Text Total;
    public void settrue()
    {
        setPoints();
        gameObject.SetActive(true);
    }

    public void setfalse(){}

    public void setPoints()
    {
        Total.text = "Total Points: "+ (LevelManager.Instance.points - LevelManager.Instance.damage);
    }
}
