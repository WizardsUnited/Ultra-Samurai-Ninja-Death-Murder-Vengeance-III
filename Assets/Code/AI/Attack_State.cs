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

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Attack State");

        isAttackStarted = true;
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Attack State");

        if (attackType != null && !isAttackFinished) 
        {
            isAttackFinished = attackType.ExecuteAttack();
        }
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Exiting Attack State");

        isAttackStarted = false;
        isAttackFinished = false;
    }
}
