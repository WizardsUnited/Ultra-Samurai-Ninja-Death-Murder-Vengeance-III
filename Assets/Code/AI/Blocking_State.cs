using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocking_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Blocking State");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Blocking State");

    }

    public override void Exit()
    {
        Debug.Log("Exiting Blocking State");
        base.Exit();
    }
}