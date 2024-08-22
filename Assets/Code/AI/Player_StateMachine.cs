using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_StateMachine : StateMachine
{
    #region VARIABLES
    private Vector3 movement;
    #endregion


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

        if (Input.GetMouseButtonDown(0))
        {
            attack.SetAttackType(m_swordLightAttack);
            ChangeState(attack);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            attack.SetAttackType(m_swordHeavyAttack);
            ChangeState(attack);
        }
        else if (movement.magnitude > 0.0f)
        {
            move.SetMovementVector(movement);
            ChangeState(move);        
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
