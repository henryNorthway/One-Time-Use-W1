using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{
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
}
