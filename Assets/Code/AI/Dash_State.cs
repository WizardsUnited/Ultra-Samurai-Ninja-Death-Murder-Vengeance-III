using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_State : State
{
    [SerializeField]
    protected float moveSpeed = 5f;

    protected Rigidbody rb;
    protected Vector3 movement;
    public void SetMovementVector(Vector3 _movement) { movement = _movement; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

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
        Debug.Log("Entering Dash State");
    }

    float timer = 0f;
    
    public override void Execute()
    {
        timer += Time.deltaTime;

        rb.velocity = transform.forward * moveSpeed * 1.5f;
        //transform.forward = movement.normalized;

        base.Execute();
        Debug.Log("Executing Dash State");

        //joint keypress to execute charge/curved slash. again, just conceptual for what is necessary, like joint keypresses for combos/certain activations


        if (timer >= stateDuration)
        {
            timer = 0f;
            Exit();
        }
    }

    public override void Exit()
    {
        animator.speed = 1f;

        Debug.Log("Exiting Dash State");
        base.Exit();
    }
}