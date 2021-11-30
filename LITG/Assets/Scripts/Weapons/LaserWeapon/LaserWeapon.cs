using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserWeapon : MonoBehaviour, BaseWeapon
{
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
    }

    public void Shoot(int range)
    {

        LayerMask mask = LayerMask.GetMask("Mirror");
        Vector3 position = transform.position;
        Vector3 direction = Camera.main.transform.forward;
        for (int i = 0; i<range;i++)
        {
            Ray ray = new Ray(position, direction);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                position = hit.point;
                direction = Vector3.Reflect(direction, hit.normal);

                lr.enabled = true;
                lr.SetPosition(i + 1, hit.point);

                if(hit.transform.name != "Mirror" )
                {
                    for(int j= (i+1);j<= 5; j++)
                    {
                        lr.SetPosition(j, hit.point);
                    }
                    break;
                }
            }
        }
    }

    public void StopShooting()
    {
        lr.enabled = false;
    }
}
