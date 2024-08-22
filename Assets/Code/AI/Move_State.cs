using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_State : State
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

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entering Move State");

        animator.Play("Move");
    }

    public override void Execute()
    {
        base.Execute();
        Debug.Log("Executing Move State");

        //print(movement);
        rb.velocity = movement * moveSpeed;
        transform.forward = movement.normalized;
    }

    public override void Exit()
    {
        Debug.Log("Exiting Move State");
        base.Exit();
    }
}
