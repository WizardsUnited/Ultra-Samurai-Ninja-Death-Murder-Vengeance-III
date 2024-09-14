using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AttackTypes
{
    //attack properties and defintiions here
    //need chain count storage, and logic for that wanted behaviour (lmb1 into rmb2? or reset. moving into idle and vice versa? where do the inputs happen, are they checked based on state? (move into move attack) or input? (shift + lmb)

    //6 light attacks (move and idle OR wasd and ctrl wasd)
    //6 heavy attacks 

    //parry, block-counter, evade-counter, charge, swish, grab?, executes : are these attacks or special/other states


    public interface IAttackType
    {
        //some hitbox and time data to funnel to attack, for now simple attacks.
        bool ExecuteAttack();
    }

    public class SwordLightAttack : IAttackType
    {
        public bool ExecuteAttack()
        {
            Debug.Log("Executing light sword attack.");
            return true;
        }
    }

    public class SwordHeavyAttack : IAttackType
    {
        public bool ExecuteAttack()
        {
            Debug.Log("Executing heavy sword attack.");
            return true;
        }
    }
}
