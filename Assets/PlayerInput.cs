//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""gunHandle"",
            ""id"": ""5abbddb5-fbd7-4986-8ed8-0fd7860f2217"",
            ""actions"": [
                {
                    ""name"": ""fire"",
                    ""type"": ""Button"",
                    ""id"": ""175abe7c-6a57-421d-b860-420fa44b66e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""reload"",
                    ""type"": ""Button"",
                    ""id"": ""40606bff-65a5-48d7-91df-b5a911d0eef2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8d82d82-6acd-431e-8e7b-cd1fe2bfacb5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b24c316-f365-4e81-9848-1f65a561f3a5"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gunHandle
        m_gunHandle = asset.FindActionMap("gunHandle", throwIfNotFound: true);
        m_gunHandle_fire = m_gunHandle.FindAction("fire", throwIfNotFound: true);
        m_gunHandle_reload = m_gunHandle.FindAction("reload", throwIfNotFound: true);
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

    // gunHandle
    private readonly InputActionMap m_gunHandle;
    private IGunHandleActions m_GunHandleActionsCallbackInterface;
    private readonly InputAction m_gunHandle_fire;
    private readonly InputAction m_gunHandle_reload;
    public struct GunHandleActions
    {
        private @PlayerInput m_Wrapper;
        public GunHandleActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @fire => m_Wrapper.m_gunHandle_fire;
        public InputAction @reload => m_Wrapper.m_gunHandle_reload;
        public InputActionMap Get() { return m_Wrapper.m_gunHandle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunHandleActions set) { return set.Get(); }
        public void SetCallbacks(IGunHandleActions instance)
        {
            if (m_Wrapper.m_GunHandleActionsCallbackInterface != null)
            {
                @fire.started -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnFire;
                @fire.performed -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnFire;
                @fire.canceled -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnFire;
                @reload.started -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnReload;
                @reload.performed -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnReload;
                @reload.canceled -= m_Wrapper.m_GunHandleActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_GunHandleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @fire.started += instance.OnFire;
                @fire.performed += instance.OnFire;
                @fire.canceled += instance.OnFire;
                @reload.started += instance.OnReload;
                @reload.performed += instance.OnReload;
                @reload.canceled += instance.OnReload;
            }
        }
    }
    public GunHandleActions @gunHandle => new GunHandleActions(this);
    public interface IGunHandleActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
}