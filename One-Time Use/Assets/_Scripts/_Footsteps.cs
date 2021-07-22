using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Footsteps : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] _clips;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Step()
    {
        AudioClip _clip = GetRandomClip();
        _audioSource.PlayOneShot(_clip);
    }

    private AudioClip GetRandomClip()
    {
        return _clips[UnityEngine.Random.Range(0, _clips.Length)];
    }
}
