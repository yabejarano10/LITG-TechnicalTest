using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticWeapon : MonoBehaviour, BaseWeapon
{
    private int Debugrange;
    public int FieldForce = 10;
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, Debugrange);
    }
    public void Shoot(int range)
    {
        LayerMask mask = LayerMask.GetMask("GravityObject");
        foreach (Collider collider in Physics.OverlapSphere(transform.position, range, mask)) {
            if(collider.gameObject.tag != "Player")
            {
                Vector3 forceDirection = transform.position - collider.transform.position;
                Debugrange = range;
                collider.GetComponent<Rigidbody>().AddForce(forceDirection.normalized * FieldForce * Time.fixedDeltaTime);
            }
        }

    }

    public void StopShooting()
    {
        
    }
}
