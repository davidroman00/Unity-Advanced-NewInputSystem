using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    //public static KeyCode InteractKeyCode;
    [SerializeField]
    GameObject _pauseMenu;
    public PlayerControllsDefault PlayerControlls;
    InputAction _move;
    InputAction _pause;
    InputAction _interact;
    //InputActionRebindingExtensions.RebindingOperation _interactRebind;
    CharacterController _characterController;
    Vector2 _moveDirection;
    void Awake()
    {
        PlayerControlls = new PlayerControllsDefault();
        _characterController = GetComponent<CharacterController>();
    }
    void OnEnable()
    {
        _move = PlayerControlls.Player.Move;
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
        CharacterMove();
    }
    private void Pause(InputAction.CallbackContext context)
    {
        _pauseMenu.SetActive(true);
    }
    private void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Interacted");
    }
    // public void RebindInteract(InputAction interactKeyCode)
    // {
    //     _interactRebind = interactKeyCode.PerformInteractiveRebinding().Start();
    //     _interactRebind.Dispose();
    // }
    void CharacterMove()
    {
        _moveDirection = _move.ReadValue<Vector2>();
        Vector3 appliedMove = new(_moveDirection.x * 3 * Time.deltaTime, 0, _moveDirection.y * 3 * Time.deltaTime);
        //_characterController.Move(appliedMove);
        transform.position += appliedMove;
    }
}
