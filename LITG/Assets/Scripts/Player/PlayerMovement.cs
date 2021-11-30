using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    private PlayerHandleWeapon handleWeapon;
    private GameManager gm;

    private bool changedWeapon = false;

    private void Start()
    {
        handleWeapon = GetComponent<PlayerHandleWeapon>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

    }

    void OnTriggerStay (Collider collision)
    {
        var go = collision.gameObject;
        if (go.tag == "weapon" && !changedWeapon)
        {
            if (transform.childCount > 1)
            {
                transform.GetChild(1).parent = null;
            }

            go.transform.parent = transform;
            go.transform.localPosition += new Vector3(1f, 0f, -0.8f);

            BaseWeapon weaponToEquip = go.GetComponent<BaseWeapon>();
            var weaponInfo = gm.GetWeaponInformation(int.Parse(go.name.Split('(')[0]));

            handleWeapon.EquipWeapon(weaponToEquip,weaponInfo);
            changedWeapon = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        changedWeapon = false;
    }
}
