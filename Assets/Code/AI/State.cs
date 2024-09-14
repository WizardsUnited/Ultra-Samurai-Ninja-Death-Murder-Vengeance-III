using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    //
    protected bool m_isLocked = false;
    public bool GetIsLocked() { return m_isLocked; }
    public bool isRepeatable = false;

    public Action OnExit;

    public bool superarmor = false, invincible = false, ghost = false;

    //
    public Animator animator;
    public float stateDuration;
    protected float stateTime = 0f;
    protected enum StatePhase { Start, Mid, End, Blocking, Deflecting, Deflected, Running, Walking, Parry }
    protected StatePhase currentPhase = StatePhase.Start;
    public StateMachine machine;

    public GameObject target;

    //parrying, blocking, etc.

    public virtual void Enter()
    {

    }

    /// <summary>
    /// Called from FixedUpdate in StateMachine.
    /// Code this method as if it is the 'FixedUpdate' method.
    /// </summary>
    public virtual void Execute()
    {
        stateTime += Time.fixedDeltaTime;
        UpdatePhase();
    }

    /// <summary>
    /// base.Exit() MUST GO LAST!   
    /// --- base.Exit() invokes callback and the script will be taken out of the execution loop before the remainder can be called.
    /// </summary>
    public virtual void Exit()
    {
        OnExit?.Invoke();
    }

    public virtual void UpdatePhase()
    {
    }
}




