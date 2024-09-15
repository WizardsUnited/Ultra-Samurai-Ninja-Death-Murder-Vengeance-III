using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Parry State");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Parry State");

    }

    public override void Exit()
    {
        Debug.Log("Exiting Parry State");
        base.Exit();
    }
}