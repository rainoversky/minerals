// GENERATED AUTOMATICALLY FROM 'Assets/07_Input/TheInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class MainInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TheInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f788455f-2667-4011-87d9-68114466af17"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2e9b3ed1-6556-4334-9e50-97b45e5324cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenInventory"",
                    ""type"": ""Button"",
                    ""id"": ""50dc90f7-ac36-4b27-ba63-0f8c2523fbb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeRobot"",
                    ""type"": ""Button"",
                    ""id"": ""dd248836-4e26-4929-a383-939023282316"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""94c3d548-d279-4e70-8a3f-945b3470f648"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Arrange"",
                    ""type"": ""Button"",
                    ""id"": ""7579c0b9-e487-4122-9a51-09a66fb4b72e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Farm"",
                    ""type"": ""Button"",
                    ""id"": ""a3d86271-e63d-4f81-93fe-a51e01a51dd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MotionTarget"",
                    ""type"": ""Value"",
                    ""id"": ""53da758c-fcd7-4a6b-8dc6-0dca299ef0b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ffad5266-10b0-43ac-8851-ac88ab37becc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Button"",
                    ""id"": ""e69667d3-40fb-409f-a72f-3f8a38a704f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0fd827d-35ec-4786-8485-db351fd2856d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4111f557-438f-4525-a3bd-a561f5843396"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb4b7434-26c4-4acc-913b-d229848062a3"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8df770ce-c814-4eec-84af-fadd6cc1bfed"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arrange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6720bdc5-0c29-48b2-9d56-5d3bb805c2ea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Farm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""604e4a57-5a1f-4916-b9f5-22a6f4ab660f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MotionTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09811b82-b15d-49e0-9872-029520041d8f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b6b4de4-3fde-4add-ab00-b17b974bae71"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fba48e8b-6df0-4f36-8902-9c633a5f0afe"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeRobot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_OpenInventory = m_Player.FindAction("OpenInventory", throwIfNotFound: true);
        m_Player_ChangeRobot = m_Player.FindAction("ChangeRobot", throwIfNotFound: true);
        m_Player_Zoom = m_Player.FindAction("Zoom", throwIfNotFound: true);
        m_Player_Arrange = m_Player.FindAction("Arrange", throwIfNotFound: true);
        m_Player_Farm = m_Player.FindAction("Farm", throwIfNotFound: true);
        m_Player_MotionTarget = m_Player.FindAction("MotionTarget", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_OpenInventory;
    private readonly InputAction m_Player_ChangeRobot;
    private readonly InputAction m_Player_Zoom;
    private readonly InputAction m_Player_Arrange;
    private readonly InputAction m_Player_Farm;
    private readonly InputAction m_Player_MotionTarget;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Walk;
    public struct PlayerActions
    {
        private MainInput m_Wrapper;
        public PlayerActions(MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @OpenInventory => m_Wrapper.m_Player_OpenInventory;
        public InputAction @ChangeRobot => m_Wrapper.m_Player_ChangeRobot;
        public InputAction @Zoom => m_Wrapper.m_Player_Zoom;
        public InputAction @Arrange => m_Wrapper.m_Player_Arrange;
        public InputAction @Farm => m_Wrapper.m_Player_Farm;
        public InputAction @MotionTarget => m_Wrapper.m_Player_MotionTarget;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @OpenInventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpenInventory;
                @ChangeRobot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeRobot;
                @ChangeRobot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeRobot;
                @ChangeRobot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeRobot;
                @Zoom.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Arrange.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArrange;
                @Arrange.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArrange;
                @Arrange.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArrange;
                @Farm.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFarm;
                @Farm.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFarm;
                @Farm.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFarm;
                @MotionTarget.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMotionTarget;
                @MotionTarget.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMotionTarget;
                @MotionTarget.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMotionTarget;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @OpenInventory.started += instance.OnOpenInventory;
                @OpenInventory.performed += instance.OnOpenInventory;
                @OpenInventory.canceled += instance.OnOpenInventory;
                @ChangeRobot.started += instance.OnChangeRobot;
                @ChangeRobot.performed += instance.OnChangeRobot;
                @ChangeRobot.canceled += instance.OnChangeRobot;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Arrange.started += instance.OnArrange;
                @Arrange.performed += instance.OnArrange;
                @Arrange.canceled += instance.OnArrange;
                @Farm.started += instance.OnFarm;
                @Farm.performed += instance.OnFarm;
                @Farm.canceled += instance.OnFarm;
                @MotionTarget.started += instance.OnMotionTarget;
                @MotionTarget.performed += instance.OnMotionTarget;
                @MotionTarget.canceled += instance.OnMotionTarget;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnOpenInventory(InputAction.CallbackContext context);
        void OnChangeRobot(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnArrange(InputAction.CallbackContext context);
        void OnFarm(InputAction.CallbackContext context);
        void OnMotionTarget(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
    }
}
