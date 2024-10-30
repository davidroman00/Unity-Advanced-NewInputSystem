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
        _playerInputController.PlayerControlls.UI.Disable();
        _playerInputController.PlayerControlls.Player.Enable();
        _pauseMenu.SetActive(false);

        Time.timeScale = 1.0f;
        Cursor.visible = false;
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

    }
}
