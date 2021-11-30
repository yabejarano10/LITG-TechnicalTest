using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BaseWeapon
{
    void Shoot(int range);

    void StopShooting();
}
