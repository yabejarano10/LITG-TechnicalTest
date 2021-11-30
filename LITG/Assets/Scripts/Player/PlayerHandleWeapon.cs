using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandleWeapon : MonoBehaviour
{
    private BaseWeapon currentWeapon;
    private Weapon weaponInfo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && currentWeapon != null && weaponInfo != null)
        {
            currentWeapon.Shoot(weaponInfo.range);
        }
        else if(currentWeapon != null)
        {
            currentWeapon.StopShooting();
        }
    }

    public void EquipWeapon(BaseWeapon weapon,Weapon info)
    {
        currentWeapon = weapon;
        weaponInfo = info;
    }

    public BaseWeapon GetCurrentWeapon()
    {
        return currentWeapon;
    }
}
