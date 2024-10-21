using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{    
    [SerializeField]
    PlayerInputController _playerInputController;
    [SerializeField]
    GameObject _pauseMenu;
    [SerializeField]
    GameObject _optionsMenu;
    [SerializeField]
    TextMeshProUGUI _interactKeybindText;
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
    public void InteractKeybindChange()
    {
        //_playerInputController.RebindInteract();
    }
}
