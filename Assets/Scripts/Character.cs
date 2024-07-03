using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private MiscScriptable miscInfo;
    [SerializeField] private MovementCommand movCommand;
    private Vector3 movementInput;
    private int timer;
    private bool timerOn;

    void Start()
    {
        UIManager.Instance.final += setfalse;
    }
    void Update()
    {
        MoveCharacter(); 
        if (timerOn)
        {
            timer --;
            if(timer <= 0)
            {
                BacktoNormal();
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(LevelManager.Instance.coins >= 20)
            {
                PUpsManager.Instance.SpawnPowerUp();
                LevelManager.Instance.UpdateCoins(- 20);
            }
        }
    }

    private void MoveCharacter()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        movementInput = new Vector3(horizontal,0,0).normalized;
        movCommand = new MovementCommand(movementInput, miscInfo.speed,Time.deltaTime,transform);
        EventQueue.Instance.QueueCommand(movCommand);
    }

    public void GetBigger()
    {
        gameObject.transform.localScale = miscInfo.biggerdimensions;
        timer = miscInfo.powertimer;
        timerOn = true;
    }

    private void BacktoNormal()
    {
        gameObject.transform.localScale = new Vector3(1,1,1);
        timerOn = false;
    }

    public void setfalse()
    {
        gameObject.SetActive(false);
    }
}
