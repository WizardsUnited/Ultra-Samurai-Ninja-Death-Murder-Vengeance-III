using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

  
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Hit State");
    }

    float timer = 0;

    public override void Execute()
    {
        timer += Time.deltaTime;

        base.Execute();
        Debug.Log("Executing Hit State");

        if (timer >= 2.5f)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting Hit State");
        base.Exit();
    }
}