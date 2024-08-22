using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    protected bool m_isLocked = false;
    public bool GetIsLocked() { return m_isLocked; }

    public Action OnExit;
    public Animator animator;

    public float stateDuration;

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

    /// <summary>
    /// base.Exit() MUST GO LAST!   
    /// --- base.Exit() invokes callback and the script will be taken out of the execution loop before the remainder can be called.
    /// </summary>
    public virtual void Exit()
    {
        OnExit?.Invoke();
    }
}




