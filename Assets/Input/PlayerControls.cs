// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""43c512a1-7ba8-44c1-8a5a-487f2a0ed70f"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""PassThrough"",
                    ""id"": ""397e1a66-1271-427d-8469-43ce9041b772"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Button"",
                    ""id"": ""91812cbb-554e-4eb2-9cc0-46e782b74eb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""72f3ab62-9f0f-4596-aedc-cac6ebe4a304"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""702a956e-0425-43c6-ae88-6c7776c7bb23"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""2d3f37ae-252c-4d8d-a8ba-6632fd3cb936"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Button"",
                    ""id"": ""9d835bbe-dcd8-4aa6-925c-bf32bca30c98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""6acec4ce-2a91-426c-b8b8-84c3e185c885"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""91517588-abd5-4aba-9a24-ff3b0b7062bf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d7b8d3d0-d461-43c8-a5dd-0ac622545e11"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d16205fd-37f1-4a95-8e2b-bd992f83e5c4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e99ea8a-85cc-40e1-90ca-79d09b56bb63"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16365ea7-a565-488b-bca1-e38c4e07b177"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1029c764-5a98-4664-aaf0-be97a4248b16"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""580b5ac2-c152-4700-ad1f-7f711c28c8e3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""546774b8-fa02-4e95-9a71-8c5f888baf4d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51cd5780-b767-4806-85d0-90e9b5627f62"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Scheme1"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Scheme1"",
            ""bindingGroup"": ""Scheme1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Select = m_PlayerMovement.FindAction("Select", throwIfNotFound: true);
        m_PlayerMovement_Throttle = m_PlayerMovement.FindAction("Throttle", throwIfNotFound: true);
        m_PlayerMovement_Steer = m_PlayerMovement.FindAction("Steer", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Brake = m_PlayerMovement.FindAction("Brake", throwIfNotFound: true);
        m_PlayerMovement_Reverse = m_PlayerMovement.FindAction("Reverse", throwIfNotFound: true);
        m_PlayerMovement_Reset = m_PlayerMovement.FindAction("Reset", throwIfNotFound: true);
        m_PlayerMovement_CameraMovement = m_PlayerMovement.FindAction("CameraMovement", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Select;
    private readonly InputAction m_PlayerMovement_Throttle;
    private readonly InputAction m_PlayerMovement_Steer;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Brake;
    private readonly InputAction m_PlayerMovement_Reverse;
    private readonly InputAction m_PlayerMovement_Reset;
    private readonly InputAction m_PlayerMovement_CameraMovement;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_PlayerMovement_Select;
        public InputAction @Throttle => m_Wrapper.m_PlayerMovement_Throttle;
        public InputAction @Steer => m_Wrapper.m_PlayerMovement_Steer;
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Brake => m_Wrapper.m_PlayerMovement_Brake;
        public InputAction @Reverse => m_Wrapper.m_PlayerMovement_Reverse;
        public InputAction @Reset => m_Wrapper.m_PlayerMovement_Reset;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerMovement_CameraMovement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSelect;
                @Throttle.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnThrottle;
                @Steer.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSteer;
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Brake.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnBrake;
                @Reverse.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReverse;
                @Reset.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReset;
                @CameraMovement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCameraMovement;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    private int m_Scheme1SchemeIndex = -1;
    public InputControlScheme Scheme1Scheme
    {
        get
        {
            if (m_Scheme1SchemeIndex == -1) m_Scheme1SchemeIndex = asset.FindControlSchemeIndex("Scheme1");
            return asset.controlSchemes[m_Scheme1SchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
    }
}
