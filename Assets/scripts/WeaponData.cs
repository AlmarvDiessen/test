using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon System/Weapon")]
public class WeaponData : ScriptableObject{
    public string weaponName;
    public int reserveAmmo;
    public int maxMagazine;
    public float fireRate;
    public float reloadTime;
    public float damage;
    public GameObject projectilePrefab;
}