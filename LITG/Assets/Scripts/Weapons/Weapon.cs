using UnityEngine;


[CreateAssetMenu(fileName ="New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    [Header("Weapon Name")]
    public string weaponName;

    [Header("Weapon Stats")]
    public int damage;
    public int range;

    [Header("Weapon Model")]
    public GameObject WeaponModel;
}
