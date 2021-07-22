using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{
    public GameObject _aboutScreen;
    private bool _isActive = false;

    public void BeginGame()
    {
        SceneManager.LoadScene("_Level01");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("_MainMenu");
    }

    public void AboutMenu()
    {
        _isActive = !_isActive;
        _aboutScreen.SetActive(_isActive);
    }
}
