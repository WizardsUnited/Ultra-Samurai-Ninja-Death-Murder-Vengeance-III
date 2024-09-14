using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityEffectorTest : MonoBehaviour
{
    public GameObject player;
    Player_StateMachine state_machine;



    void Start()
    {
        state_machine = player.GetComponent<Player_StateMachine>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            state_machine.isHit = true;
        }
    }
}
