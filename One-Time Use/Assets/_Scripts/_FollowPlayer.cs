using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _FollowPlayer : MonoBehaviour
{
    public Transform _player;
    public Vector3 _offset;

    void Update()
    {
        transform.position = _player.position + _offset;
    }
}
