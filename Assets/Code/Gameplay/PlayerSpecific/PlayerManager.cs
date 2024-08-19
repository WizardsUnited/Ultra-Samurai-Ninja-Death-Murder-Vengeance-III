using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    Player_StateMachine myStateMachine;

    private void Start()
    {
        if (myStateMachine = GetComponent<Player_StateMachine>())
            Debug.Log("Player_StateMachine Found");
        else
            Debug.Log("Player_StateMachine NOT Found");

        if (myStateMachine != null)
            Initialize();
        else
            Debug.Log("FAILED TO INITIALIZE: Player_StateMachine NOT Found");
    }

    /// <summary>
    /// Called from Start.
    /// Code this method as if it is the 'Start' method.
    /// </summary>
    private void Initialize()
    {
        
    }

    private void Update()
    {
        
    }
}
