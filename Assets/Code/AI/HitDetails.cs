using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HitDetails
{
    public float damage;
    public Vector3 direction;
    public State sender_ToChange;
    public State receiver_ToChange;
    public float hitStun;
    public float frameStun;
    public int hit_id;

    public HitDetails() { }

    public HitDetails(float _damage, Vector3 _direction, State _sender_ToChange, State _receiver_ToChange, float _hitStun, float _frameStun, int _hit_id) { damage = _damage; direction = _direction; sender_ToChange = _sender_ToChange; receiver_ToChange = _receiver_ToChange; hitStun = _hitStun; frameStun = _frameStun; hit_id = _hit_id; }

    public HitDetails(float _damage, Vector3 _direction, float _hitStun, float _frameStun, int _hit_id) { damage = _damage; direction = _direction; hitStun = _hitStun; frameStun = _frameStun; hit_id = _hit_id; }

}