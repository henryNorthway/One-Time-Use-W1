// GENERATED AUTOMATICALLY FROM 'Assets/_InputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @_InputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @_InputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""_InputAction"",
    ""maps"": [
        {
            ""name"": ""_userActions"",
            ""id"": ""2f01a4fb-6505-43ef-a4c4-0842ef097b36"",
            ""actions"": [
                {
                    ""name"": ""_Move"",
                    ""type"": ""Button"",
                    ""id"": ""cbb65d4f-1f3f-4024-bfea-de5f7934052f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_Interact"",
                    ""type"": ""Button"",
                    ""id"": ""4bea1938-34bf-473b-9f43-7a9e2200be1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b5adf790-823d-426e-a664-e7ccc21dc606"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1163af39-98a2-441f-8a8a-602f8fd2d164"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a0ac1b1a-ddff-4bff-b371-372b05785e0a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c824fffa-16c7-41e3-b0da-76dea9775a71"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec7e5eab-2a5b-4293-826a-4abe677fc93f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91690a75-1c50-45a6-96b7-2068738e5062"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8e6fa9f6-c4f1-4f46-a2e9-c6ad2fdc2b1c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ef7cb77a-408f-463b-a36a-3234d1955ada"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5607f340-78cf-418a-b322-a780a574e890"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50233b71-cb3a-4fc7-8384-ed3c3f9617cc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f014bfb2-3971-43a0-a7cc-c31bdfc47c21"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e9707a5-5865-4ea6-9999-7c1837084435"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c3e9921-a66f-45ae-a411-40851fa0e420"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a7373363-b2c1-4217-9b48-589dbae6be15"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c188f37-35c9-4d09-bd06-176b25327e5b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""_userInterface"",
            ""id"": ""1effd036-18ed-47a4-8be9-c44f74dfa335"",
            ""actions"": [
                {
                    ""name"": ""_Move"",
                    ""type"": ""Button"",
                    ""id"": ""1ac6829d-25a1-4fd6-b11b-3a261956f2c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""a6fb72e4-196e-4de5-85e3-1fc2c1f4ad8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""96543736-8628-4616-b06a-9b8850b5bb58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""92e94585-dfaa-403e-90e0-4e4a281b45f4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""59dfba00-45ca-4ed2-8ed8-007df9faa04a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f3a96b0-0350-4af6-9fa7-86eefaa848e3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4721daa0-f587-4545-9c54-ce645c944af6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d16bc8f2-5092-4afb-813a-a91ab0d5675b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""015c997d-8b48-4f20-97a8-08beecc736d6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f3e04504-2680-410e-898a-72f40cce694a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""82039c7a-6d56-4959-9d9d-a8255be8df6b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b1c60117-2af9-4b3e-99cf-25e829260dba"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""63eb488b-983a-4916-a388-deee4154a48b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""56aa3027-5b87-4438-b288-0d8c2e7de6d4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8b44d1-584f-4766-8ef2-e13aa3fafbcf"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // _userActions
        m__userActions = asset.FindActionMap("_userActions", throwIfNotFound: true);
        m__userActions__Move = m__userActions.FindAction("_Move", throwIfNotFound: true);
        m__userActions__Interact = m__userActions.FindAction("_Interact", throwIfNotFound: true);
        m__userActions__Pause = m__userActions.FindAction("_Pause", throwIfNotFound: true);
        m__userActions__Jump = m__userActions.FindAction("_Jump", throwIfNotFound: true);
        // _userInterface
        m__userInterface = asset.FindActionMap("_userInterface", throwIfNotFound: true);
        m__userInterface__Move = m__userInterface.FindAction("_Move", throwIfNotFound: true);
        m__userInterface__Confirm = m__userInterface.FindAction("_Confirm", throwIfNotFound: true);
        m__userInterface__Cancel = m__userInterface.FindAction("_Cancel", throwIfNotFound: true);
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

    // _userActions
    private readonly InputActionMap m__userActions;
    private I_userActionsActions m__userActionsActionsCallbackInterface;
    private readonly InputAction m__userActions__Move;
    private readonly InputAction m__userActions__Interact;
    private readonly InputAction m__userActions__Pause;
    private readonly InputAction m__userActions__Jump;
    public struct _userActionsActions
    {
        private @_InputAction m_Wrapper;
        public _userActionsActions(@_InputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @_Move => m_Wrapper.m__userActions__Move;
        public InputAction @_Interact => m_Wrapper.m__userActions__Interact;
        public InputAction @_Pause => m_Wrapper.m__userActions__Pause;
        public InputAction @_Jump => m_Wrapper.m__userActions__Jump;
        public InputActionMap Get() { return m_Wrapper.m__userActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_userActionsActions set) { return set.Get(); }
        public void SetCallbacks(I_userActionsActions instance)
        {
            if (m_Wrapper.m__userActionsActionsCallbackInterface != null)
            {
                @_Move.started -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Move;
                @_Move.performed -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Move;
                @_Move.canceled -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Move;
                @_Interact.started -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Interact;
                @_Interact.performed -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Interact;
                @_Interact.canceled -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Interact;
                @_Pause.started -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Pause;
                @_Pause.performed -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Pause;
                @_Pause.canceled -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Pause;
                @_Jump.started -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Jump;
                @_Jump.performed -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Jump;
                @_Jump.canceled -= m_Wrapper.m__userActionsActionsCallbackInterface.On_Jump;
            }
            m_Wrapper.m__userActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_Move.started += instance.On_Move;
                @_Move.performed += instance.On_Move;
                @_Move.canceled += instance.On_Move;
                @_Interact.started += instance.On_Interact;
                @_Interact.performed += instance.On_Interact;
                @_Interact.canceled += instance.On_Interact;
                @_Pause.started += instance.On_Pause;
                @_Pause.performed += instance.On_Pause;
                @_Pause.canceled += instance.On_Pause;
                @_Jump.started += instance.On_Jump;
                @_Jump.performed += instance.On_Jump;
                @_Jump.canceled += instance.On_Jump;
            }
        }
    }
    public _userActionsActions @_userActions => new _userActionsActions(this);

    // _userInterface
    private readonly InputActionMap m__userInterface;
    private I_userInterfaceActions m__userInterfaceActionsCallbackInterface;
    private readonly InputAction m__userInterface__Move;
    private readonly InputAction m__userInterface__Confirm;
    private readonly InputAction m__userInterface__Cancel;
    public struct _userInterfaceActions
    {
        private @_InputAction m_Wrapper;
        public _userInterfaceActions(@_InputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @_Move => m_Wrapper.m__userInterface__Move;
        public InputAction @_Confirm => m_Wrapper.m__userInterface__Confirm;
        public InputAction @_Cancel => m_Wrapper.m__userInterface__Cancel;
        public InputActionMap Get() { return m_Wrapper.m__userInterface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_userInterfaceActions set) { return set.Get(); }
        public void SetCallbacks(I_userInterfaceActions instance)
        {
            if (m_Wrapper.m__userInterfaceActionsCallbackInterface != null)
            {
                @_Move.started -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Move;
                @_Move.performed -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Move;
                @_Move.canceled -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Move;
                @_Confirm.started -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Confirm;
                @_Confirm.performed -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Confirm;
                @_Confirm.canceled -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Confirm;
                @_Cancel.started -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Cancel;
                @_Cancel.performed -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Cancel;
                @_Cancel.canceled -= m_Wrapper.m__userInterfaceActionsCallbackInterface.On_Cancel;
            }
            m_Wrapper.m__userInterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_Move.started += instance.On_Move;
                @_Move.performed += instance.On_Move;
                @_Move.canceled += instance.On_Move;
                @_Confirm.started += instance.On_Confirm;
                @_Confirm.performed += instance.On_Confirm;
                @_Confirm.canceled += instance.On_Confirm;
                @_Cancel.started += instance.On_Cancel;
                @_Cancel.performed += instance.On_Cancel;
                @_Cancel.canceled += instance.On_Cancel;
            }
        }
    }
    public _userInterfaceActions @_userInterface => new _userInterfaceActions(this);
    public interface I_userActionsActions
    {
        void On_Move(InputAction.CallbackContext context);
        void On_Interact(InputAction.CallbackContext context);
        void On_Pause(InputAction.CallbackContext context);
        void On_Jump(InputAction.CallbackContext context);
    }
    public interface I_userInterfaceActions
    {
        void On_Move(InputAction.CallbackContext context);
        void On_Confirm(InputAction.CallbackContext context);
        void On_Cancel(InputAction.CallbackContext context);
    }
}
