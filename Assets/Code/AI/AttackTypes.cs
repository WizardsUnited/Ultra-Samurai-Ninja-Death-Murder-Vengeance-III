using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AttackTypes
{
    public interface IAttackType
    {
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
