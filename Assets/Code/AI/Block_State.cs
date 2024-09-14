using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_State : State
{
    public void Awake()
    {
        invincible = true;
        isRepeatable = true;
    }

    public override void Enter()
    {
        machine.isBlocking = true;

        base.Enter();
        Debug.Log("Entering Block State");

        animator.Play("Block");
        stateDuration = 2f;
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Block State");

        //check for hit in this state

        if (currentPhase == StatePhase.Blocking)
        {
            //something to do with resetting time of state is being left out i think
            //check inputs for second press (AND during framepause period?
            //animation change (before framepause)
            //only lasts during framepause. goes into deflect back to block/other state or hasblocked_recovery/other state after framepause. so really this is just one frame animation as is, no transition in, transition out perhaps, but all just phase animations, still blocking and probably cancellable
        }

        if (currentPhase == StatePhase.Deflecting)
        {
            //animation change after blocking pose framestun phase. still blocking, still cancellabe
        }

        if (currentPhase == StatePhase.Start)
        {
            Debug.Log("Parry");
            //change locked stuffs

            //apply hit to target(make target hit, put sender in cancelleable parry anim, framestun, hitstun, damage, velocity (all the hit resolution stuff is set to happen, but happens after the framestun occurs.)


        }

        //parry area and some auxproc for activating some sub-state and theoertically adding hitbox/action/interaction efect that is parry
        //^predicated by "can effect other things states"
        //imaginig sifu cutscene move or continuous move like grapple turn throw theoertically superarmored. the splitting of those states i guess? "superarmor" + "long ik interaction"
        //for now, thinking very simple about telegraphing of some of these states. just adding functionality for using these states and sub-states. more complex animation control and mathcing starts at attacks, then the rest is simpler, from experience and hitboxes


    }

    public override void Exit()
    {
        machine.isBlocking = false;

        stateTime = 0;

        Debug.Log("Exiting Block State");
        base.Exit();
    }

    public override void UpdatePhase()
    {
        //

        if (stateTime < stateDuration * 0.1f)
        {
            currentPhase = StatePhase.Start;
        }
        else if (stateTime < stateDuration * 0.66f)
        {
            currentPhase = StatePhase.Mid;
        }
        else
        {
            currentPhase = StatePhase.End;
        }
    }
}