// GENERATED AUTOMATICALLY FROM 'Assets/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""be3e1e19-5f1f-4448-920d-ea30764ce034"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Button"",
                    ""id"": ""e03c18de-e8d4-4b61-bc30-0dfc5549157b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize(min=1,max=1)"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Bomb"",
                    ""type"": ""Button"",
                    ""id"": ""6bedce90-c5f1-452b-8fb9-146ce4ba57be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PewPew"",
                    ""type"": ""Button"",
                    ""id"": ""16566e86-c903-47a7-87b5-b0e1042dd783"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slowing Down"",
                    ""type"": ""Button"",
                    ""id"": ""47ce29cd-cb76-437e-88b0-3cec9d9c98fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Normalize"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""47b88310-5d14-4689-9344-1d2f06be2941"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f5c6e19-34f7-4933-a23f-ad134176b163"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""569690cd-9890-4ef3-9c02-816f235085f5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d04c9699-d8d0-4bb0-8c99-dc3fe75b54c9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""38edf71d-3bb1-4c9c-8c5a-14711e3624a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""8369aad8-51cf-4627-a385-e3cae72e75cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18623087-7d96-45c4-9e77-23245519369f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cd252d12-1c55-4674-932a-2511932cfbbc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""52645d28-9aac-4f9c-b960-d1717e3c4031"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d343bda6-feef-497c-81f5-2f10d76b7a71"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b4cdaa33-16b2-42fd-9c7b-ebcea17e0e41"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13df8552-7b90-4b52-92ce-68a894ad73f5"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PewPew"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4705a5b6-ff75-4ed3-a7cc-f9385e17bc36"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slowing Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Moving
        m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
        m_Moving_Moving = m_Moving.FindAction("Moving", throwIfNotFound: true);
        m_Moving_Bomb = m_Moving.FindAction("Bomb", throwIfNotFound: true);
        m_Moving_PewPew = m_Moving.FindAction("PewPew", throwIfNotFound: true);
        m_Moving_SlowingDown = m_Moving.FindAction("Slowing Down", throwIfNotFound: true);
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

    // Moving
    private readonly InputActionMap m_Moving;
    private IMovingActions m_MovingActionsCallbackInterface;
    private readonly InputAction m_Moving_Moving;
    private readonly InputAction m_Moving_Bomb;
    private readonly InputAction m_Moving_PewPew;
    private readonly InputAction m_Moving_SlowingDown;
    public struct MovingActions
    {
        private @PlayerMovement m_Wrapper;
        public MovingActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_Moving_Moving;
        public InputAction @Bomb => m_Wrapper.m_Moving_Bomb;
        public InputAction @PewPew => m_Wrapper.m_Moving_PewPew;
        public InputAction @SlowingDown => m_Wrapper.m_Moving_SlowingDown;
        public InputActionMap Get() { return m_Wrapper.m_Moving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
        public void SetCallbacks(IMovingActions instance)
        {
            if (m_Wrapper.m_MovingActionsCallbackInterface != null)
            {
                @Moving.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMoving;
                @Moving.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMoving;
                @Moving.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMoving;
                @Bomb.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnBomb;
                @Bomb.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnBomb;
                @Bomb.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnBomb;
                @PewPew.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnPewPew;
                @PewPew.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnPewPew;
                @PewPew.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnPewPew;
                @SlowingDown.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlowingDown;
                @SlowingDown.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlowingDown;
                @SlowingDown.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnSlowingDown;
            }
            m_Wrapper.m_MovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moving.started += instance.OnMoving;
                @Moving.performed += instance.OnMoving;
                @Moving.canceled += instance.OnMoving;
                @Bomb.started += instance.OnBomb;
                @Bomb.performed += instance.OnBomb;
                @Bomb.canceled += instance.OnBomb;
                @PewPew.started += instance.OnPewPew;
                @PewPew.performed += instance.OnPewPew;
                @PewPew.canceled += instance.OnPewPew;
                @SlowingDown.started += instance.OnSlowingDown;
                @SlowingDown.performed += instance.OnSlowingDown;
                @SlowingDown.canceled += instance.OnSlowingDown;
            }
        }
    }
    public MovingActions @Moving => new MovingActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMovingActions
    {
        void OnMoving(InputAction.CallbackContext context);
        void OnBomb(InputAction.CallbackContext context);
        void OnPewPew(InputAction.CallbackContext context);
        void OnSlowingDown(InputAction.CallbackContext context);
    }
}
