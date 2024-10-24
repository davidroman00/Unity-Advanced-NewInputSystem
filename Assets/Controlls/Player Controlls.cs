//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controlls/Player Controlls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControlls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controlls"",
    ""maps"": [
        {
            ""name"": ""Options Menu Controlls"",
            ""id"": ""a71b93f1-155a-4051-9f6f-d29dffbc5ece"",
            ""actions"": [
                {
                    ""name"": ""Mouse Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1893a764-ca2b-40b2-b6b9-04d2403f2c49"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""3e57f7a3-6562-435f-8ec8-3815b7ad7501"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8888f8b0-86b2-4351-b215-2e2962a9348b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90363ca4-ed78-4ac9-b56c-40642bb8bb61"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Game Controlls"",
            ""id"": ""2669b470-442b-4b91-baf7-0cb473be989f"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b3c0f22-a9e1-4d87-91b1-a0ff069c4c22"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""be3d50d7-4309-41bb-bcd4-af240a9a26a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""deb77654-8681-4d0a-9f0e-a1499e56f45e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""61742fad-4ff7-4ce6-ac6f-15e7e2d5ef95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump/Double Jump"",
                    ""type"": ""Button"",
                    ""id"": ""643449d8-ad54-4dbb-ac71-06aa94bc6149"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""5c6770a1-3f83-4da4-bc87-e487812f4e35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd692d76-b5ec-45d6-b3aa-ab7c089800d8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7220b14c-baa9-448b-bd9d-da4d9c369ba7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""5c4af567-6ab0-4e00-af2b-18cb5257b38c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9948c662-009b-4487-99cf-31b3d2ba2e0b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d45b2889-0812-446f-8bf9-51990e17d31e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""068b8699-4399-499c-9183-6e0e2668b0d4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""46c6df43-312e-4157-9efb-8b7b6e410616"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""76766be4-944e-46a7-aa77-54b2aecb4929"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""650a4e2f-872e-479a-bf38-76bed037b360"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""MultiTap(tapDelay=0.6)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump/Double Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d8d43cd-456b-4900-909c-136469c34997"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Options Menu Controlls
        m_OptionsMenuControlls = asset.FindActionMap("Options Menu Controlls", throwIfNotFound: true);
        m_OptionsMenuControlls_MouseMove = m_OptionsMenuControlls.FindAction("Mouse Move", throwIfNotFound: true);
        m_OptionsMenuControlls_Click = m_OptionsMenuControlls.FindAction("Click", throwIfNotFound: true);
        // Player Game Controlls
        m_PlayerGameControlls = asset.FindActionMap("Player Game Controlls", throwIfNotFound: true);
        m_PlayerGameControlls_Camera = m_PlayerGameControlls.FindAction("Camera", throwIfNotFound: true);
        m_PlayerGameControlls_Interaction = m_PlayerGameControlls.FindAction("Interaction", throwIfNotFound: true);
        m_PlayerGameControlls_Movement = m_PlayerGameControlls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerGameControlls_Pause = m_PlayerGameControlls.FindAction("Pause", throwIfNotFound: true);
        m_PlayerGameControlls_JumpDoubleJump = m_PlayerGameControlls.FindAction("Jump/Double Jump", throwIfNotFound: true);
        m_PlayerGameControlls_Sprint = m_PlayerGameControlls.FindAction("Sprint", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Options Menu Controlls
    private readonly InputActionMap m_OptionsMenuControlls;
    private List<IOptionsMenuControllsActions> m_OptionsMenuControllsActionsCallbackInterfaces = new List<IOptionsMenuControllsActions>();
    private readonly InputAction m_OptionsMenuControlls_MouseMove;
    private readonly InputAction m_OptionsMenuControlls_Click;
    public struct OptionsMenuControllsActions
    {
        private @PlayerControlls m_Wrapper;
        public OptionsMenuControllsActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseMove => m_Wrapper.m_OptionsMenuControlls_MouseMove;
        public InputAction @Click => m_Wrapper.m_OptionsMenuControlls_Click;
        public InputActionMap Get() { return m_Wrapper.m_OptionsMenuControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OptionsMenuControllsActions set) { return set.Get(); }
        public void AddCallbacks(IOptionsMenuControllsActions instance)
        {
            if (instance == null || m_Wrapper.m_OptionsMenuControllsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OptionsMenuControllsActionsCallbackInterfaces.Add(instance);
            @MouseMove.started += instance.OnMouseMove;
            @MouseMove.performed += instance.OnMouseMove;
            @MouseMove.canceled += instance.OnMouseMove;
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IOptionsMenuControllsActions instance)
        {
            @MouseMove.started -= instance.OnMouseMove;
            @MouseMove.performed -= instance.OnMouseMove;
            @MouseMove.canceled -= instance.OnMouseMove;
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IOptionsMenuControllsActions instance)
        {
            if (m_Wrapper.m_OptionsMenuControllsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOptionsMenuControllsActions instance)
        {
            foreach (var item in m_Wrapper.m_OptionsMenuControllsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OptionsMenuControllsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OptionsMenuControllsActions @OptionsMenuControlls => new OptionsMenuControllsActions(this);

    // Player Game Controlls
    private readonly InputActionMap m_PlayerGameControlls;
    private List<IPlayerGameControllsActions> m_PlayerGameControllsActionsCallbackInterfaces = new List<IPlayerGameControllsActions>();
    private readonly InputAction m_PlayerGameControlls_Camera;
    private readonly InputAction m_PlayerGameControlls_Interaction;
    private readonly InputAction m_PlayerGameControlls_Movement;
    private readonly InputAction m_PlayerGameControlls_Pause;
    private readonly InputAction m_PlayerGameControlls_JumpDoubleJump;
    private readonly InputAction m_PlayerGameControlls_Sprint;
    public struct PlayerGameControllsActions
    {
        private @PlayerControlls m_Wrapper;
        public PlayerGameControllsActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_PlayerGameControlls_Camera;
        public InputAction @Interaction => m_Wrapper.m_PlayerGameControlls_Interaction;
        public InputAction @Movement => m_Wrapper.m_PlayerGameControlls_Movement;
        public InputAction @Pause => m_Wrapper.m_PlayerGameControlls_Pause;
        public InputAction @JumpDoubleJump => m_Wrapper.m_PlayerGameControlls_JumpDoubleJump;
        public InputAction @Sprint => m_Wrapper.m_PlayerGameControlls_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGameControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGameControllsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerGameControllsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerGameControllsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerGameControllsActionsCallbackInterfaces.Add(instance);
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @JumpDoubleJump.started += instance.OnJumpDoubleJump;
            @JumpDoubleJump.performed += instance.OnJumpDoubleJump;
            @JumpDoubleJump.canceled += instance.OnJumpDoubleJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
        }

        private void UnregisterCallbacks(IPlayerGameControllsActions instance)
        {
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @JumpDoubleJump.started -= instance.OnJumpDoubleJump;
            @JumpDoubleJump.performed -= instance.OnJumpDoubleJump;
            @JumpDoubleJump.canceled -= instance.OnJumpDoubleJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
        }

        public void RemoveCallbacks(IPlayerGameControllsActions instance)
        {
            if (m_Wrapper.m_PlayerGameControllsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerGameControllsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerGameControllsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerGameControllsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerGameControllsActions @PlayerGameControlls => new PlayerGameControllsActions(this);
    public interface IOptionsMenuControllsActions
    {
        void OnMouseMove(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
    public interface IPlayerGameControllsActions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnJumpDoubleJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
