// GENERATED AUTOMATICALLY FROM 'Assets/InputSchema/Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Control : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f4cf4bd1-6d16-484d-a20c-1cb6a2d6a2cb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""efeaee38-efa7-412c-8974-46b0e021d32b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""5a162b77-10df-4522-a80c-90ab41fa0dbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8d8ea10b-eb78-4c40-9fb3-b176b00fc9d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""68622e58-bbce-44fc-9220-0b4796253f16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6470d844-abea-4ba9-8b32-47158b581731"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9dc6a2fe-c8a5-4861-9017-f57003fe019e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e16e72f3-db17-426a-bfc7-7c70d3a1a618"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""aa51cb18-5279-40ee-a0cf-d3a59ee90ae0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2e8df0ca-52e0-40b1-8ae5-cc2541f57647"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e591a073-c0e3-4b0e-80d2-1e759a634a3d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8f3e6be2-aa59-4d29-9c9b-49e81407f413"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""757cdfb6-8819-40de-b4ed-eff0cb7af7e2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b2c12608-740a-4c67-b9a9-54900f031bd8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""58a193e5-edeb-46a7-bf79-c4037ac2a1f0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c2d36c37-4986-4f0e-8449-c73e9444e586"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80932238-b644-4da9-950f-4a02a081915b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fc93cd88-b933-4556-9e91-7fec9ae643b6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86583cc2-eefd-4dec-b27f-ad7ef8723635"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20c3953a-e8a7-47ee-9f46-3c00a53d33f4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7cdc701-2765-45e8-9697-b5ef576d9602"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66d8085f-ac0c-4f98-897a-10ccdedfd4f7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d2e4993-4d30-495e-a038-0fb2f7e748f7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""0d4e669c-b8a9-496e-be14-4b6d706d7438"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""92027f3c-5380-4d44-ac76-a1e78847f964"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""55bef253-8edc-4a44-b3ec-8ee870bfe920"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e6a225d9-da58-4212-bf9e-6ad033ce62d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""fd0c2f5a-52e6-4eb7-bc16-02e2c726535a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e1e1daf3-c6fc-4503-8727-311d876415d8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1957dd20-f24f-460c-9622-1ec11849347a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c02d8440-7e10-41c4-8506-7f86708fc692"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""96c5475b-36da-4bad-b767-d94af0ab7de3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""92300859-da32-46d3-b6bf-81ded1267891"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""73068689-5f19-471f-84ff-5f2a6c5fa889"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""af98cfae-a2aa-486f-9c9b-fd52d141e8a3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""839633ed-1662-42d8-a544-504cecbefe49"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""016b15e2-1eea-4ed6-8483-70e51afea87d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""56470a44-ec4d-4d5c-b95e-900f4610c16a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ad58ea32-d8e5-4f95-8772-22ec26d20784"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""91c8b1e4-e9fa-4087-8a12-5b6933d7dc20"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a74fa1f-2535-4501-b1e2-5b10c35b92fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdca250e-9b8a-43e0-84aa-8e828538253c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8abed152-e185-41a9-9ad9-09316c81e62c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc74f9b6-234f-4ca2-83c0-482e1537ea87"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19e9f0fc-9f7a-4f2c-8019-9fbdb6c3fbb5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e820328-c4b3-49b9-9a64-809d4dd0f82e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DialogAction"",
            ""id"": ""073ea658-6f18-4af0-b8b3-94ac794c2c74"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""23c88226-ea8c-46d2-b501-51b1563b1add"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CallDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""f2c8d9ab-7cb5-4e4a-92e9-4eb5900b5587"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""5b22a36a-98b6-4f60-937c-48cd1bf81f6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""393905b4-e315-4cba-9c22-99208e654d4b"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d028322f-e71e-4996-ab5d-2a70232bdf4c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""269917c2-c7b3-4b72-bc38-8eff3b0202b8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CallDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9ae3f1a-b68c-4534-82fe-ce074aa39471"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d7d227-94fe-4337-9fec-a6a77fac3d5a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Vertical = m_Player.FindAction("Vertical", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Movement = m_Player2.FindAction("Movement", throwIfNotFound: true);
        m_Player2_Vertical = m_Player2.FindAction("Vertical", throwIfNotFound: true);
        m_Player2_Shoot = m_Player2.FindAction("Shoot", throwIfNotFound: true);
        m_Player2_Run = m_Player2.FindAction("Run", throwIfNotFound: true);
        // DialogAction
        m_DialogAction = asset.FindActionMap("DialogAction", throwIfNotFound: true);
        m_DialogAction_Confirm = m_DialogAction.FindAction("Confirm", throwIfNotFound: true);
        m_DialogAction_CallDialogue = m_DialogAction.FindAction("CallDialogue", throwIfNotFound: true);
        m_DialogAction_Cancel = m_DialogAction.FindAction("Cancel", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Vertical;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Run;
    public struct PlayerActions
    {
        private @Control m_Wrapper;
        public PlayerActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Vertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Movement;
    private readonly InputAction m_Player2_Vertical;
    private readonly InputAction m_Player2_Shoot;
    private readonly InputAction m_Player2_Run;
    public struct Player2Actions
    {
        private @Control m_Wrapper;
        public Player2Actions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2_Movement;
        public InputAction @Vertical => m_Wrapper.m_Player2_Vertical;
        public InputAction @Shoot => m_Wrapper.m_Player2_Shoot;
        public InputAction @Run => m_Wrapper.m_Player2_Run;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                @Vertical.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Shoot.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @Run.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // DialogAction
    private readonly InputActionMap m_DialogAction;
    private IDialogActionActions m_DialogActionActionsCallbackInterface;
    private readonly InputAction m_DialogAction_Confirm;
    private readonly InputAction m_DialogAction_CallDialogue;
    private readonly InputAction m_DialogAction_Cancel;
    public struct DialogActionActions
    {
        private @Control m_Wrapper;
        public DialogActionActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_DialogAction_Confirm;
        public InputAction @CallDialogue => m_Wrapper.m_DialogAction_CallDialogue;
        public InputAction @Cancel => m_Wrapper.m_DialogAction_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_DialogAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogActionActions set) { return set.Get(); }
        public void SetCallbacks(IDialogActionActions instance)
        {
            if (m_Wrapper.m_DialogActionActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnConfirm;
                @CallDialogue.started -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCallDialogue;
                @CallDialogue.performed -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCallDialogue;
                @CallDialogue.canceled -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCallDialogue;
                @Cancel.started -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_DialogActionActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_DialogActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @CallDialogue.started += instance.OnCallDialogue;
                @CallDialogue.performed += instance.OnCallDialogue;
                @CallDialogue.canceled += instance.OnCallDialogue;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public DialogActionActions @DialogAction => new DialogActionActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IDialogActionActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnCallDialogue(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
