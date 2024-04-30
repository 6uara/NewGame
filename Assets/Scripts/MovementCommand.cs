using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCommand : MonoBehaviour,ICommand
{
    private readonly Vector3 direction;
    private readonly float speed;
    private readonly float deltaTime;
    private readonly Transform transformTarget;


    public void Move(){
        transformTarget.position +=  direction * (speed * deltaTime);
    }
}
