//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Ethan's Stuff/Controller Support Stuff/TheControls.inputactions
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

public partial class @TheControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TheControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TheControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""2dcac892-2a5a-4320-a92b-91d117009dc4"",
            ""actions"": [
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""da55f408-086d-432c-ae54-d097b0a6bec4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""04fbe600-1996-48e3-a668-1707d750f527"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""dd7b3ff5-fd7b-4abb-84ab-26b1ad5a9279"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory L"",
                    ""type"": ""Button"",
                    ""id"": ""1eb3090a-2122-4be3-9cad-7af05818665c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory R"",
                    ""type"": ""Button"",
                    ""id"": ""e33ee82c-aeb4-44b3-ba73-f5db6142f97a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08790f6c-2697-49ff-bd47-540e6c8403d7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7338d267-5e65-4822-9d36-2a8c8497afee"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae35ff1c-d889-49f7-8c59-1fef5e72e313"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""676add89-d6fa-497e-97dd-307f333da5d4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4420e1a-d80e-4668-b72f-3232cbcdb66a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Sprint = m_GamePlay.FindAction("Sprint", throwIfNotFound: true);
        m_GamePlay_Interact = m_GamePlay.FindAction("Interact", throwIfNotFound: true);
        m_GamePlay_Pause = m_GamePlay.FindAction("Pause", throwIfNotFound: true);
        m_GamePlay_InventoryL = m_GamePlay.FindAction("Inventory L", throwIfNotFound: true);
        m_GamePlay_InventoryR = m_GamePlay.FindAction("Inventory R", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Sprint;
    private readonly InputAction m_GamePlay_Interact;
    private readonly InputAction m_GamePlay_Pause;
    private readonly InputAction m_GamePlay_InventoryL;
    private readonly InputAction m_GamePlay_InventoryR;
    public struct GamePlayActions
    {
        private @TheControls m_Wrapper;
        public GamePlayActions(@TheControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sprint => m_Wrapper.m_GamePlay_Sprint;
        public InputAction @Interact => m_Wrapper.m_GamePlay_Interact;
        public InputAction @Pause => m_Wrapper.m_GamePlay_Pause;
        public InputAction @InventoryL => m_Wrapper.m_GamePlay_InventoryL;
        public InputAction @InventoryR => m_Wrapper.m_GamePlay_InventoryR;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Sprint.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSprint;
                @Interact.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
                @Pause.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @InventoryL.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryL;
                @InventoryL.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryL;
                @InventoryL.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryL;
                @InventoryR.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryR;
                @InventoryR.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryR;
                @InventoryR.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInventoryR;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @InventoryL.started += instance.OnInventoryL;
                @InventoryL.performed += instance.OnInventoryL;
                @InventoryL.canceled += instance.OnInventoryL;
                @InventoryR.started += instance.OnInventoryR;
                @InventoryR.performed += instance.OnInventoryR;
                @InventoryR.canceled += instance.OnInventoryR;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnSprint(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInventoryL(InputAction.CallbackContext context);
        void OnInventoryR(InputAction.CallbackContext context);
    }
}