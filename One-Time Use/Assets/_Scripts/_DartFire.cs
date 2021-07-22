using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DartFire : MonoBehaviour
{
    private AudioSource _dart;

    void Awake()
    {
        _dart = GetComponent<AudioSource>();
    }

    private void FireDart()
    {
        _dart.Play(0);
    }
}
