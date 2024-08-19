using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    #region ALL POSSIBLE STATES
    /* Do not need to fill all, Start will fill all that an object contains
     */
    protected Idle_State idle;
    protected Move_State move;
    #endregion

    /// <summary>
    /// runtime variable
    /// </summary>
    protected State currentState;

    private void Start()
    {
        if (idle = GetComponent<Idle_State>())
            Debug.Log("Idle Found");
        else
            Debug.Log("Idle NOT Found");

        if (move = GetComponent<Move_State>())
            Debug.Log("Move Found");
        else
            Debug.Log("Move NOT Found");

        if (idle != null)
            Initialize(idle);
        else
            Debug.Log("FAILED TO INITIALIZE: Idle NOT Found");
    }



    public virtual void Initialize(State initialState)
    {
        currentState = initialState;
        currentState.Enter();
    }

    protected virtual void ChangeState(State newState)
    {
        if (newState != currentState)
        {
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        } 
    }

    protected virtual void Update()
    {
        
    }

    protected virtual void FixedUpdate()
    {
        currentState.Execute();
    }
}
