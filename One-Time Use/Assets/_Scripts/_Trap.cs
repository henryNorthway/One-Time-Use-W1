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

    public void TriggerTrap()
    {
        switch (_trapName)
        {
            case "Trapdoor":
                Destroy(_trap);
                _trapName = null;
                break;
            case "Falling Block":
                _trapAnimator.SetBool("_isTriggered", true);
                break;
            case "Darts":
                _trapAnimator.SetBool("_isTriggered", true);
                break;
            default:
                Destroy(this.gameObject);
                _player.DestroyFloatingText();
                _winScreen.WinScreen();
                break;
        }
    }
}
