using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_State : Move_State
{
    /// <summary>
    /// Testing XML heirarchy interaction
    /// </summary>
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Player_Move State");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Player_Move State");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Exiting Player_Move State");
    }
}
