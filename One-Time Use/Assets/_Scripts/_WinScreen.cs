using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _WinScreen : MonoBehaviour
{
    public GameObject _winScreenUI;
    public Button _placeholderButton;

    public void WinScreen()
    {
        FindObjectOfType<_Player>().OnDisable();
        _winScreenUI.SetActive(true);
        Time.timeScale = 0f;
        _placeholderButton.Select();
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_MainMenu");
    }
}
