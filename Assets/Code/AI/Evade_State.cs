    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade_State : State
{
    private void Awake()
    {
        m_isLocked = true;
    }

    public override void Enter()
    {
        stateDuration = .3f;
        animator.Play("Evade");
        animator.Update(0);

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float clipLength = stateInfo.length;

        // Calculate the required playback speed to match the state duration
        float playbackSpeed = clipLength / stateDuration;

        // Set the animator speed to match the desired state duration
        animator.speed = playbackSpeed;

        base.Enter();
        Debug.Log("Entering Evade State");
    }
    
    float timer = 0f;

    public override void Execute()
    {
        timer += Time.deltaTime;

        //"not effectable" through hitbox shit. i-frames. otherwise, effects could be applied, considering superarmor/misc

        //parry area and some auxproc for activating some sub-state and theoertically adding hitbox/action/interaction efect that is parry
        //^predicated by "can effect other things states"

        base.Execute();
        Debug.Log("Executing Evade State");

        if (timer >= stateDuration) {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        animator.speed = 1f;

        Debug.Log("Exiting Evade State");
        base.Exit();
    }
}