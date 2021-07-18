using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerAnimation : MonoBehaviour
{
    public Animator _playerAnimator;

    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    public void Moving(bool _playerState)
    {
        if (_playerState)
        {
            _playerAnimator.SetBool("_isIdle", false);
            _playerAnimator.SetBool("_isMoving", true);
        }
        else
        {
            _playerAnimator.SetBool("_isIdle", true);
            _playerAnimator.SetBool("_isMoving", false);
        }
        
    }

    public void Jumping(bool _playerState)
    {
        _playerAnimator.SetBool("_isGrounded", _playerState);
    }
}
