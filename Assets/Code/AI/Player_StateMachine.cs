using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_StateMachine : StateMachine
{
    private Vector3 movement;



    public override void Initialize(State initialState)
    {
        base.Initialize(initialState);
    }

    protected override void ChangeState(State newState)
    {
        base.ChangeState(newState);
    }

    protected override void Update()
    {
        base.Update();

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveX, 0.0f, moveZ).normalized;
        if (movement.magnitude > 0.0f)
        {
            ChangeState(move);
            move.SetMovementVector(movement);
        }
        else
        {
            ChangeState(idle);
        }
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}
