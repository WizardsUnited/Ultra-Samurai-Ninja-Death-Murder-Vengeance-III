using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AttackTypes;
using Dbug;

public class StateMachine : MonoBehaviour
{
    #region ALL POSSIBLE STATES
    /* Do not need to fill all, Start will fill all that an object contains
     */
    protected Idle_State idle; //unlocked
    protected Move_State move; //unlocked
    //attack (soft-)locked (cancellable?)
    protected IAttackType m_swordLightAttack, m_swordHeavyAttack;
    protected Attack_State attack;
    //dash (/roll, long iframes) locked
    //evade (sidestep, short iframes) locked
    //block \/
    //parry /\
    #endregion

    /// <summary>
    /// runtime variable
    /// </summary>
    protected State currentState;

    private void Start()
    {
        if (idle = GetComponent<Idle_State>())
            Log.Good("Idle found. " + gameObject.name);
        else
            Log.Warning("Idle NOT Found. " + gameObject.name);

        if (move = GetComponent<Move_State>())
            Log.Good("Move Found. " + gameObject.name);
        else
            Log.Warning("Move NOT Found. " + gameObject.name);

        if (attack = GetComponent<Attack_State>())
        {
            Log.Good("Attack Found. " + gameObject.name);
            attack.OnExit += OnLockedStateExit;
        }
        else
            Log.Warning("Attack NOT Found. " + gameObject.name);

        if (idle != null)
            Initialize(idle);
        else
            Log.Warning("FAILED TO INITIALIZE: Idle NOT Found. " + gameObject.name);
    }



    public virtual void Initialize(State initialState)
    {
        currentState = initialState;
        currentState.Enter();
        m_swordLightAttack = new SwordLightAttack();
        m_swordHeavyAttack = new SwordHeavyAttack();
    }

    protected virtual void ChangeState(State newState)
    {
        if(!currentState.GetIsLocked()) // if (unlocked state) { switch freely }
        {
            if (newState != currentState) // Change state may be called more times than neccersary 
            {
                currentState.Exit();
                currentState = newState;
                currentState.Enter();
            }
        }
    }

    private void OnLockedStateExit()
    {
        currentState = idle;
        currentState.Enter();
    }

    protected virtual void Update()
    {
        
    }

    protected virtual void FixedUpdate()
    {
        currentState.Execute();
    }
}
