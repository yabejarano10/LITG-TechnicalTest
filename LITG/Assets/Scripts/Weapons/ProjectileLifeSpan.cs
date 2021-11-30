using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifeSpan : MonoBehaviour
{
    public float SecondsToDie = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }
    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(SecondsToDie);
        Destroy(gameObject);    
    }
}
