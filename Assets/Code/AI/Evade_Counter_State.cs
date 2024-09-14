    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade_Counter_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Evade Counter State");
    }
    
    float timer = 0f;

    public override void Execute()
    {
        timer += Time.deltaTime;

        base.Execute();
        Debug.Log("Executing Evade Counter State");

        if (timer >= stateDuration) {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting Evade Counter State");
        base.Exit();
    }
}