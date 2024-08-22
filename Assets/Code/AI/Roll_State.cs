using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        stateDuration = 1f;
        animator.Play("Roll");
        animator.Update(0);

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float clipLength = stateInfo.length;

        // Calculate the required playback speed to match the state duration
        float playbackSpeed = clipLength / stateDuration;

        // Set the animator speed to match the desired state duration
        animator.speed = playbackSpeed;

        base.Enter();
        Debug.Log("Entering Roll State");
    }

    float timer = 0f;
    
    public override void Execute()
    {
        timer += Time.deltaTime;

        base.Execute();
        Debug.Log("Executing Roll State");

        if (timer >= stateDuration)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        animator.speed = 1f;

        Debug.Log("Exiting Roll State");
        base.Exit();
    }
}