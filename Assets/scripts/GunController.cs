using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour{
    [SerializeField] private Weapon weapon;
    [SerializeField] private WeaponData weaponData;
    private PlayerInput playerInput;
    private PlayerInput.GunHandleActions gunActions;

    public event Action _onShoot;
    public event Action _onReload;

    private void Awake(){
        playerInput = new PlayerInput();
        weapon = gameObject.AddComponent<Weapon>();
        weapon.Initialize(weaponData);
        gunActions = playerInput.gunHandle;
    }

    private void OnEnable(){
        gunActions.Enable();
        gunActions.fire.performed += HandleShoot;
        gunActions.reload.performed += HanldeReload;
    }

    private void OnDisable(){
        gunActions.fire.performed -= HandleShoot;
        gunActions.reload.performed += HanldeReload;
        gunActions.Disable();
    }

    private void HandleShoot(InputAction.CallbackContext context){
        _onShoot?.Invoke();
    }

    private void HanldeReload(InputAction.CallbackContext context){
        _onReload?.Invoke();
    }
}