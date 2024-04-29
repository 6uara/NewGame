using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float movementSpeed;


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

        Vector3 movementInput = new Vector3(horizontal,0,0).normalized;

        transform.position += movementInput * (Time.deltaTime * movementSpeed);
    }

    private void Interact(){
        Debug.Log("Try");
    }
}
