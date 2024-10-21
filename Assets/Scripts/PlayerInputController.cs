using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField]
    GameObject _pauseMenu;
    public PlayerControllsDefault PlayerControlls;
    InputAction _move;
    InputAction _pause;
    InputAction _interact;
    void Awake()
    {
        PlayerControlls = new PlayerControllsDefault();
    }
    void OnEnable()
    {
        _move = PlayerControlls.Player.Pause;
        _pause = PlayerControlls.Player.Pause;
        _interact = PlayerControlls.Player.Interact;

        _move.Enable();
        _pause.Enable();
        _interact.Enable();

        _pause.performed += Pause;
        _interact.performed += Interact;
    }
    void OnDisable()
    {
        _move.Disable();
        _pause.Disable();
        _interact.Disable();
    }
    void Update()
    {

    }
    private void Pause(InputAction.CallbackContext context){
        _pauseMenu.SetActive(true);
    }
    private void Interact(InputAction.CallbackContext context){
        Debug.Log("Interacted");
    }
}
