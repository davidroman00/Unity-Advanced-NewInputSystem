using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public PlayerControllsDefault PlayerControlls;
    private InputAction _move;
    private InputAction _pause;
    void Awake()
    {
        PlayerControlls = new PlayerControllsDefault();
    }
    void OnEnable()
    {
        _move = PlayerControlls.Player.Pause;
        _pause = PlayerControlls.Player.Pause;

        _move.Enable();
        _pause.Enable();

        _pause.performed += Pause;
    }
    void OnDisable()
    {
        _move.Disable();
        _pause.Disable();
    }
    void Update()
    {

    }
    private void Pause(InputAction.CallbackContext context){
        Debug.Log("MEmeme");
    }
}
