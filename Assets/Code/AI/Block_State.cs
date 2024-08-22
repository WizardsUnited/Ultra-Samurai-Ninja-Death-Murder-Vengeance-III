using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Block State");

        animator.Play("Block");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Block State");
    }

    public override void Exit()
    {
        Debug.Log("Exiting Block State");
        base.Exit();
    }
}