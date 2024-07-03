using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCommand : ICommand
{
    private readonly Vector3 direction;
    private readonly float speed;
    private readonly float deltaTime;
    private readonly Transform transformTarget;

    public MovementCommand(Vector3 direction,float speed, float deltaTime,Transform ttarget){
        this.direction = direction;
        this.speed = speed;
        this.deltaTime = deltaTime;
        transformTarget = ttarget;
    }


    public void Execute(){
        transformTarget.position +=  direction * (speed * deltaTime);
    }
}
