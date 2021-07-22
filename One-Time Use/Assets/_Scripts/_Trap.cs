using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Trap : MonoBehaviour
{
    public string _trapName;
    public GameObject _trap;
    public _Player _player;
    public _WinScreen _winScreen;
    public Animator _trapAnimator;

    private AudioSource _trapSFX;

    void Awake()
    {
        _trapSFX = GetComponent<AudioSource>();
    }

    public void TriggerTrap()
    {
        switch (_trapName)
        {
            case "Trapdoor":
                _trapSFX.Play(0);
                Destroy(_trap);
                _trapName = null;
                break;
            case "Falling Block":
                PressurePlatePressed();
                break;
            case "Darts":
                PressurePlatePressed();
                break;
            default:
                Destroy(this.gameObject);
                _player.DestroyFloatingText();
                _winScreen.WinScreen();
                break;
        }
    }

    private void PressurePlatePressed()
    {
        //transform.Translate(Vector3.down * Time.deltaTime);
        _trapAnimator.SetBool("_isTriggered", true);
        _trapSFX.Play(0);
    }
}
