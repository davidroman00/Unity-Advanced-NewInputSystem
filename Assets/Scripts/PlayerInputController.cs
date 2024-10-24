using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : MonoBehaviour
{
    //public static KeyCode InteractKeyCode;
    [SerializeField]
    GameObject _pauseMenu;
    [SerializeField]
    Transform _camera;
    public PlayerControllsDefault PlayerControlls;
    InputAction _move;
    InputAction _look;
    InputAction _pause;
    InputAction _interact;
    //InputActionRebindingExtensions.RebindingOperation _interactRebind;
    CharacterController _characterController;
    Vector3 _moveDirection;
    Vector2 _initialDirection;
    [SerializeField]
    float _speed;
    float _turnSmoothTime = .075f;
    float _turnSmoothVelocity;
    float _targetAngle;
    float _appliedAngle;
    void Awake()
    {
        PlayerControlls = new PlayerControllsDefault();
        _characterController = GetComponent<CharacterController>();
    }
    void OnEnable()
    {
        _move = PlayerControlls.Player.Move;
        _look = PlayerControlls.Player.Look;
        _pause = PlayerControlls.Player.Pause;
        _interact = PlayerControlls.Player.Interact;

        _move.Enable();
        _look.Enable();
        _pause.Enable();
        _interact.Enable();

        _pause.performed += Pause;
        _interact.performed += Interact;
    }
    void OnDisable()
    {
        _move.Disable();
        _look.Disable();
        _pause.Disable();
        _interact.Disable();
    }

    void Update()
    {
        CharacterMoveAndRotation();
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
    void CharacterMoveAndRotation()
    {
        _initialDirection = _move.ReadValue<Vector2>();
        //_initialDirection = new(_moveDirection.x, 0, _moveDirection.y);

        _targetAngle = Mathf.Atan2(_initialDirection.x, _initialDirection.y) * Mathf.Rad2Deg + _camera.eulerAngles.y;
        _appliedAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetAngle, ref _turnSmoothVelocity, _turnSmoothTime);
        transform.rotation = Quaternion.Euler(0, _appliedAngle, 0);

        _moveDirection = Quaternion.Euler(0, _targetAngle, 0) * Vector3.forward;
        _characterController.Move(_speed * Time.deltaTime * _moveDirection);

        Debug.Log(_initialDirection);
    }
}
/*
        
*/
