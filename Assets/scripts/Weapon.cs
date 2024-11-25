using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour{
    private string weaponName;
    private int reserveAmmo;
    private int currentAmmo;
    private int maxMagazine;
    private float fireRate;
    private float reloadTime;
    private float damage;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    private void Awake(){
        bulletSpawnPoint = transform.Find("bulletSpawnPoint");
        if (bulletSpawnPoint == null){
            Debug.LogError("bulletSpawnPoint not found in the gun's hierarchy.");
        }
    }

    private void OnEnable(){
        var gunController = GetComponent<GunController>();
        if (gunController != null){
            gunController._onShoot += Shoot;
            gunController._onReload += StartReload;
        }
    }

    private void OnDisable(){
        var gunController = GetComponent<GunController>();
        if (gunController != null){
            gunController._onShoot -= Shoot;
            gunController._onReload -= StartReload;
        }
    }

    private void StartReload(){
        StartCoroutine(Reload());
    }

    public virtual void Shoot(){
        Debug.Log("Shooting");
        if (currentAmmo > 0){
            currentAmmo--;
            Debug.Log(currentAmmo + " ammo left");
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnPoint.forward * 10, ForceMode.Impulse);
        }
    }

    public virtual IEnumerator Reload(){
        yield return new WaitForSeconds(reloadTime);
        int ammoNeeded = maxMagazine - currentAmmo;
        Debug.Log(ammoNeeded + " ammo needed");
        if (reserveAmmo == 0){
            Debug.Log("No reserve ammo");
            yield break;
        }

        if (reserveAmmo >= ammoNeeded){
            reserveAmmo -= ammoNeeded;
            currentAmmo = maxMagazine;
            Debug.Log(reserveAmmo + " reserve ammo left");
        }
        else{
            currentAmmo += reserveAmmo;
            reserveAmmo = 0;
        }
    }

    public void Initialize(WeaponData weaponData){
        weaponName = weaponData.weaponName;
        reserveAmmo = weaponData.reserveAmmo;
        maxMagazine = weaponData.maxMagazine;
        currentAmmo = maxMagazine;
        fireRate = weaponData.fireRate;
        reloadTime = weaponData.reloadTime;
        damage = weaponData.damage;
        bulletPrefab = weaponData.projectilePrefab;
    }

    //add gizmo to show the bullet spawn point      
}