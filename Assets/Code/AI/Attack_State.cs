using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AttackTypes;

public class Attack_State : State
{
    private bool isAttackStarted = false;
    private bool isAttackFinished = false;
    private IAttackType attackType;

    public void SetAttackType(IAttackType _attackType)
    {
        if (!isAttackStarted) { attackType = _attackType; }
        else { Debug.Log("ERROR: AttackInProgress: " + attackType + ". \nTried to SetAttackType to: " + _attackType); }
    }

    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Attack State");

        isAttackStarted = true;
    }

    float timer = 0;

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Attack State");

        timer += Time.deltaTime;

        //Physics.Overlap from IAttack data. consider whether frame data should be here or there

        //if (attackType != null && !isAttackFinished) 
        //{
        //    isAttackFinished = attackType.ExecuteAttack();
        //}

        if (timer >= 1f)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        isAttackStarted = false;
        isAttackFinished = false;

        Debug.Log("Exiting Attack State");
        base.Exit();
    }
}
