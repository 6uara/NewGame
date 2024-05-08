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
    }

    private void MoveCharacter()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        movementInput = new Vector3(horizontal,0,0).normalized;
        movCommand = new MovementCommand(movementInput, movementSpeed,Time.deltaTime,transform);
        EventQueue.Instance.QueueCommand(movCommand);
    }
}
