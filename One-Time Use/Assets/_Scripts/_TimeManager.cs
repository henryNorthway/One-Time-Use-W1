using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _TimeManager : MonoBehaviour
{
    public float _slowdownFactor = 0.05f;
    public _Player _player;
    bool _isSlowedDown = false;

    void Update()
    {
        Time.timeScale += Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);

        if (_isSlowedDown && Time.timeScale == 1f)
        {
            _isSlowedDown = false;
            _player.Respawn();
        }
    }

    public void SlowMotion()
    {
        _isSlowedDown = true;
        Time.timeScale = _slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
