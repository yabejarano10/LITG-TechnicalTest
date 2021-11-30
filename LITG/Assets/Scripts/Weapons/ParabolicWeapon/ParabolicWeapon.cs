using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicWeapon : MonoBehaviour, BaseWeapon
{
    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("ParabolicBullet") as GameObject;
    }

    public void Shoot(int range)
    {
        GameObject projectile = Instantiate(prefab) as GameObject;
        projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * range;
    }

    public void StopShooting()
    {
       
    }
}
