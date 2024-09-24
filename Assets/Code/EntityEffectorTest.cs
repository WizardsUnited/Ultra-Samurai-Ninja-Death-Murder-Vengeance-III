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
        HitDetails hit = new HitDetails(0, new Vector3(0, 0, 0), .33f, .1f, 0);

        if (Input.GetKeyDown(KeyCode.P))
        {
            state_machine.ApplyHitEffect(state_machine, hit);
        }
    }


}
