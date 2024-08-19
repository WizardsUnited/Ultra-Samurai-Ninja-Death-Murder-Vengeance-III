using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Idle State");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Idle State");
    }

    public override void Exit() 
    { 
        base.Exit();
        Debug.Log("Exiting Idle State");
    }
}
