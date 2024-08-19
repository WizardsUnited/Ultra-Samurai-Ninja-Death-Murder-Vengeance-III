using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public virtual void Enter()
    {

    }

    /// <summary>
    /// Called from FixedUpdate in StateMachine.
    /// Code this method as if it is the 'FixedUpdate' method.
    /// </summary>
    public virtual void Execute()
    {

    }

    public virtual void Exit()
    {

    }
}
