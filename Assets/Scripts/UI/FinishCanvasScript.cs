using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishCanvasScript : MonoBehaviour
{
    [SerializeField] private TMP_Text Total;

    private void Awake() {
        UIManager.Instance.final += settrue;
        gameObject.SetActive(false);
    }
    public void settrue()
    {
        setPoints();
        gameObject.SetActive(true);
    }

    public void setPoints()
    {
        Total.text = "Total Points: "+ (LevelManager.Instance.points - LevelManager.Instance.damage);
    }
}
