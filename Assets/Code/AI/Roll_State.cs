using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Roll State");
    }

    float timer = 0f;
    
    public override void Execute()
    {
        timer += Time.deltaTime;

        base.Execute();
        Debug.Log("Executing Roll State");

        if (timer >= 1f)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting Roll State");
        base.Exit();
    }
}