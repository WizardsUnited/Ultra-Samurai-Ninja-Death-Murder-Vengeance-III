using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Idle State");

        animator.Play("Idle");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Idle State");
    }

    public override void Exit() 
    {
        Debug.Log("Exiting Idle State");
        base.Exit();    
    }
}
