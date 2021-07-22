using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _WinScreen : MonoBehaviour
{
    public GameObject _winScreenUI;
    private AudioSource _fanfare;

    void Awake()
    {
        _fanfare = GetComponent<AudioSource>();
    }

    public void WinScreen()
    {
        FindObjectOfType<_Player>().OnDisable();
        _winScreenUI.SetActive(true);
        _fanfare.Play(0);
        Time.timeScale = 0f;
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
