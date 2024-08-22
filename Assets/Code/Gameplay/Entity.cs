using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Entity : MonoBehaviour
{
    #region VARIABLES
    [SerializeField]
    protected uint startingHealth = 1;
    [SerializeField]
    private bool IsKillable = true;
    protected float health;
    #endregion

    protected virtual void Start()
    {
        health = startingHealth;
    }

    public virtual void TakeDamage(float _dmgAmount)
    {
        health -= _dmgAmount;
        if (health < 0 && IsKillable)
        {
            Kill();
        }
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}
