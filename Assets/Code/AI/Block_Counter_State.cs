using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Counter_State : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Block Counter State");

    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Block Counter  State");
    }

    public override void Exit()
    {
        Debug.Log("Exiting Block Counter  State");
        base.Exit();
    }
}