using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject ControlsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void OpenController()
    {
        ControlsWindow.SetActive(true);
    }

    public void CloseController()
    {
        ControlsWindow.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
