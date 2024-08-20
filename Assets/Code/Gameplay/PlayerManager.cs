using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerManager : Entity
{
    protected override void Start()
    {
        base.Start();
    }

    public override void TakeDamage(float _dmgAmount)
    {
        base.TakeDamage(_dmgAmount);
    }
}
