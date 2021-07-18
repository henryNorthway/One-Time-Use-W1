using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _PauseGame : MonoBehaviour
{
    public static bool _isPaused = false;
    public GameObject _pauseMenuUI;
    public Button _resumeButton;

    public void PauseGame()
    {
        if (_isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        FindObjectOfType<_Player>().OnEnable();
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _isPaused = false;
    }

    void Pause()
    {
        FindObjectOfType<_Player>().OnDisable();
        _pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _isPaused = true;
        _resumeButton.Select();
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_MainMenu");
    }
}
