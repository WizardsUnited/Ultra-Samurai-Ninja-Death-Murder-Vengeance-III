using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AttackTypes
{
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
