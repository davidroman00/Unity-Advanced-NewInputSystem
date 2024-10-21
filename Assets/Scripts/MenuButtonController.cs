using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField]
    GameObject _pauseMenu;
    [SerializeField]
    GameObject _optionsMenu;
    public void ResumeGame()
    {
        _pauseMenu.SetActive(false);
    }
    public void ShowOptions()
    {
        _optionsMenu.SetActive(true);
        _pauseMenu.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        _pauseMenu.SetActive(true);
        _optionsMenu.SetActive(false);
    }
}
