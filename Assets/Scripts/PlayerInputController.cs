using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerInputController : MonoBehaviour
{
    //public static KeyCode InteractKeyCode;
    [SerializeField]
    GameObject _pauseMenu;
    [SerializeField]
    Transform _camera;
    public PlayerControllsDefault PlayerControlls;
    InputAction _move;
    //InputAction _look;
    InputAction _pause;
    InputAction _interact;
    //InputActionRebindingExtensions.RebindingOperation _interactRebind;
    CharacterController _characterController;
    Vector3 _moveDirection;
    Vector3 _initialDirection;
    [SerializeField]
    float _speed;
    float _turnSmoothTime = .075f;
    float _turnSmoothVelocity;
    float _targetAngle;
    float _appliedAngle;
    //[SerializeField]
    //GameObject[] _itemSlots;
    public List<Item> Inventory = new();
    Collider _interactableObject;

    public class Item
    {
        public SpriteRenderer InventoryImage;
        public Item(SpriteRenderer img)
        {
            InventoryImage = img;
        }
    }
    void Awake()
    {
        PlayerControlls = new PlayerControllsDefault();
        _characterController = GetComponent<CharacterController>();
    }
    void OnEnable()
    {
        _move = PlayerControlls.Player.Move;
        //_look = PlayerControlls.Player.Look;
        _pause = PlayerControlls.Player.Pause;
        _interact = PlayerControlls.Player.Interact;

        _move.Enable();
        //_look.Enable();
        _pause.Enable();
        _interact.Enable();

        _pause.performed += Pause;
        _interact.performed += Interact;
    }
    void OnDisable()
    {
        _move.Disable();
        //_look.Disable();
        _pause.Disable();
        _interact.Disable();
    }

    void Update()
    {
        if (_move.ReadValue<Vector2>().magnitude > .05f)
        {
            CharacterMoveAndRotation();
        }
    }
    private void Pause(InputAction.CallbackContext context)
    {
        _pauseMenu.SetActive(true);
    }
    private void Interact(InputAction.CallbackContext context)
    {
        if (_interactableObject != null)
        {
            string tag = _interactableObject.tag;
            switch (tag)
            {//lo hago con switch por si en el futuro el numero de interacciones sube más.
                case "Chest":
                    ChestInteraction();
                    break;
                case "Item":
                    ItemPickUp();
                    break;
            }
        }
    }
    void ChestInteraction()
    {
        ChestRandomAlgorithm chest = _interactableObject.GetComponentInParent<ChestRandomAlgorithm>();
        chest.OnChestOpen();
    }
    void ItemPickUp()
    {
        //if (Inventory.Count < _itemSlots.Length)
        //{
        CollectibleItemLogic pickedItem = _interactableObject.GetComponent<CollectibleItemLogic>();
        Item newInventoryItem = new(pickedItem.Image);
        Inventory.Add(newInventoryItem);
        pickedItem.OnItemPicked();
        //RefreshInventoryUI();
        //}
        //else
        //{
        Debug.Log("Objeto recogido");
        //}
    }
    /*void RefreshInventoryUI()
    {
        for (int i = 0; i < _itemSlots.Length && i < Inventory.Count; i++)
        {
            Image img = _itemSlots[i].GetComponent<Image>();
            img.sprite = Inventory[i].InventoryImage.sprite;
            Color imgColor = img.color;
            imgColor.a = 255;
            img.color = imgColor;
        }
    }*/
    void OnTriggerEnter(Collider collider)
    {
        _interactableObject = collider;
    }
    // public void RebindInteract(InputAction interactKeyCode)
    // {
    //     _interactRebind = interactKeyCode.PerformInteractiveRebinding().Start();
    //     _interactRebind.Dispose();
    // }
    void CharacterMoveAndRotation()
    {
        Vector2 inputVector = _move.ReadValue<Vector2>();
        _initialDirection = new(inputVector.x, 0f, inputVector.y);

        _targetAngle = Mathf.Atan2(_initialDirection.x, _initialDirection.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
        _appliedAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetAngle, ref _turnSmoothVelocity, _turnSmoothTime);
        transform.rotation = Quaternion.Euler(0, _appliedAngle, 0);

        _moveDirection = Quaternion.Euler(0, _targetAngle, 0) * Vector3.forward;
        _characterController.Move(_speed * Time.deltaTime * _moveDirection);
    }
}

