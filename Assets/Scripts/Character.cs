using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private MovementCommand movCommand;
    private Vector3 movementInput;

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        if(Input.GetKeyDown(KeyCode.E)){
            Interact();
        }
        
    }

    private void MoveCharacter()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        //var vertical = Input.GetAxisRaw("Vertical");

        movementInput = new Vector3(horizontal,0,0).normalized;
        movCommand = new MovementCommand(movementInput, movementSpeed,Time.deltaTime,transform);
        //movCommand.Execute();
        EventQueue.Instance.QueueCommand(movCommand);
        //transform.position += movementInput * (Time.deltaTime * movementSpeed);
    }

    private void Interact(){
        Debug.Log("Try");
    }
}
