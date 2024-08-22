using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy_StateMachine : StateMachine
{
    #region VARIABLES
    private Vector3 movement;
    #endregion

    bool isHit = false;

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
        
        if (isHit)
        {
            ChangeState(hit);
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
