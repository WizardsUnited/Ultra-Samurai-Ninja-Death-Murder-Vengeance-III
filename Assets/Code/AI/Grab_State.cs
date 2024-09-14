using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Grab State");

    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Grab State");

    }

    public override void Exit()
    {
        Debug.Log("Exiting Grab State");
        base.Exit();
    }
}