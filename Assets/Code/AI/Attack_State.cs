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
        superarmor = true;
    }

    public override void Enter()
    {
        stateDuration = 1.5f;
        animator.Play("Attack");
        animator.Update(0);

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float clipLength = stateInfo.length;

        // Calculate the required playback speed to match the state duration
        float playbackSpeed = clipLength / stateDuration;

        // Set the animator speed to match the desired state duration
        animator.speed = playbackSpeed;

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

        if (timer >= stateDuration)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        isAttackStarted = false;
        isAttackFinished = false;

        animator.speed = 1f;

        Debug.Log("Exiting Attack State");
        base.Exit();
    }
}
