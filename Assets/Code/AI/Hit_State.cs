using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

  
    public override void Enter()
    {
        stateDuration = .5f;
        animator.Play("Hit");
        animator.Update(0);

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float clipLength = stateInfo.length;

        // Calculate the required playback speed to match the state duration
        float playbackSpeed = clipLength / stateDuration;

        // Set the animator speed to match the desired state duration
        animator.speed = playbackSpeed;

        base.Enter();
        Debug.Log("Entering Hit State");
    }

    float timer = 0;

    public override void Execute()
    {
        timer += Time.deltaTime;

        base.Execute();
        Debug.Log("Executing Hit State");

        if (timer >= stateDuration)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        animator.speed = 1f;

        Debug.Log("Exiting Hit State");
        base.Exit();
    }
}