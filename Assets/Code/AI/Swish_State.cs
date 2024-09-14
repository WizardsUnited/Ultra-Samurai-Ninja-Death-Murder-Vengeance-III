using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AttackTypes;

public class Swish_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Swish State");
    }

    float timer = 0;

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Swish State");

        timer += Time.deltaTime;

        if (timer >= stateDuration)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting Swish State");
        base.Exit();
    }
}
