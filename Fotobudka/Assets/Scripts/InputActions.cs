// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""InpAct"",
            ""id"": ""c9f0ae51-7569-4c41-a2eb-503de6d81f51"",
            ""actions"": [
                {
                    ""name"": ""DeltaRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""acfe5054-fd29-4222-91cc-2b2b201fb68e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""663b9be7-3bf0-4c0c-9985-437931453609"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""emulateScroll"",
                    ""type"": ""Button"",
                    ""id"": ""2742c94d-64a7-43b3-8a3f-744b81413408"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""73f1fe1e-a0a7-453f-b464-4c73a8e2cf9b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""31ce7988-7f01-41dc-882e-78124671c30f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UnClick"",
                    ""type"": ""Button"",
                    ""id"": ""40ffbaee-b1cd-4a5b-b707-70dcee0f6fe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3b47f58-bf98-4df6-84a6-2ebb7436d5e7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0f7a33b-195b-41cb-a702-f20408e5e3dd"",
                    ""path"": ""<VirtualMouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ce60517f-3eb5-417c-a48b-fe7a825a7bdd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b832ab49-9d15-4f7b-aa88-ba4dd236ece8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c605a180-e5a7-4566-8ac1-31f1e8cb166e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c2dae51c-64ff-412e-a7b1-0975f31d5e06"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""39f2b95e-2938-4c22-97c3-05acc458a2f0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2ed322f6-3cd8-4911-8ff1-a0b8e90d5989"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""307730da-887a-4f7c-b8b6-25c9f4b3d4c1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""36fe6c12-4cfa-46f9-b7cc-821ae7e7c307"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""820358fc-e8a0-4872-b2fe-778a73a284cb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""05c4dc87-d047-4805-92cb-4c3fe84ff03b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeltaRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6b1c4177-4ad0-4261-a77e-001e4fb9b61e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c257943c-1c98-4fb4-99fb-7aedfb366132"",
                    ""path"": ""<VirtualMouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fc5c51d-8a2e-4fdf-847b-05ec3112c710"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""emulateScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac3cf480-1422-437c-8913-dbd6ad712894"",
                    ""path"": ""<VirtualMouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""emulateScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a5f3669-1f42-4424-ad90-a2db5f78323e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""emulateScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50fa1924-85e7-45d9-984b-eda96c9a318d"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a4dc41-4886-4f76-9e86-cd7a11e13b19"",
                    ""path"": ""<VirtualMouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8946ec6c-7f63-4e63-b427-7940f59ef91c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e647d816-a31b-49d5-b3a9-4db989686d2a"",
                    ""path"": ""<VirtualMouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb4d32bc-509d-43f8-b231-12aad99947ac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e85f4811-05f9-4d67-9aa7-16283ec48f7c"",
                    ""path"": ""<VirtualMouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InpAct
        m_InpAct = asset.FindActionMap("InpAct", throwIfNotFound: true);
        m_InpAct_DeltaRotation = m_InpAct.FindAction("DeltaRotation", throwIfNotFound: true);
        m_InpAct_Click = m_InpAct.FindAction("Click", throwIfNotFound: true);
        m_InpAct_emulateScroll = m_InpAct.FindAction("emulateScroll", throwIfNotFound: true);
        m_InpAct_Scroll = m_InpAct.FindAction("Scroll", throwIfNotFound: true);
        m_InpAct_MousePosition = m_InpAct.FindAction("MousePosition", throwIfNotFound: true);
        m_InpAct_UnClick = m_InpAct.FindAction("UnClick", throwIfNotFound: true);
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

    // InpAct
    private readonly InputActionMap m_InpAct;
    private IInpActActions m_InpActActionsCallbackInterface;
    private readonly InputAction m_InpAct_DeltaRotation;
    private readonly InputAction m_InpAct_Click;
    private readonly InputAction m_InpAct_emulateScroll;
    private readonly InputAction m_InpAct_Scroll;
    private readonly InputAction m_InpAct_MousePosition;
    private readonly InputAction m_InpAct_UnClick;
    public struct InpActActions
    {
        private @InputActions m_Wrapper;
        public InpActActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DeltaRotation => m_Wrapper.m_InpAct_DeltaRotation;
        public InputAction @Click => m_Wrapper.m_InpAct_Click;
        public InputAction @emulateScroll => m_Wrapper.m_InpAct_emulateScroll;
        public InputAction @Scroll => m_Wrapper.m_InpAct_Scroll;
        public InputAction @MousePosition => m_Wrapper.m_InpAct_MousePosition;
        public InputAction @UnClick => m_Wrapper.m_InpAct_UnClick;
        public InputActionMap Get() { return m_Wrapper.m_InpAct; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InpActActions set) { return set.Get(); }
        public void SetCallbacks(IInpActActions instance)
        {
            if (m_Wrapper.m_InpActActionsCallbackInterface != null)
            {
                @DeltaRotation.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnDeltaRotation;
                @DeltaRotation.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnDeltaRotation;
                @DeltaRotation.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnDeltaRotation;
                @Click.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnClick;
                @emulateScroll.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnEmulateScroll;
                @emulateScroll.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnEmulateScroll;
                @emulateScroll.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnEmulateScroll;
                @Scroll.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnScroll;
                @MousePosition.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnMousePosition;
                @UnClick.started -= m_Wrapper.m_InpActActionsCallbackInterface.OnUnClick;
                @UnClick.performed -= m_Wrapper.m_InpActActionsCallbackInterface.OnUnClick;
                @UnClick.canceled -= m_Wrapper.m_InpActActionsCallbackInterface.OnUnClick;
            }
            m_Wrapper.m_InpActActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DeltaRotation.started += instance.OnDeltaRotation;
                @DeltaRotation.performed += instance.OnDeltaRotation;
                @DeltaRotation.canceled += instance.OnDeltaRotation;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @emulateScroll.started += instance.OnEmulateScroll;
                @emulateScroll.performed += instance.OnEmulateScroll;
                @emulateScroll.canceled += instance.OnEmulateScroll;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @UnClick.started += instance.OnUnClick;
                @UnClick.performed += instance.OnUnClick;
                @UnClick.canceled += instance.OnUnClick;
            }
        }
    }
    public InpActActions @InpAct => new InpActActions(this);
    public interface IInpActActions
    {
        void OnDeltaRotation(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnEmulateScroll(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnUnClick(InputAction.CallbackContext context);
    }
}
