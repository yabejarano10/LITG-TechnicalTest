using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowName(string name)
    {
        var namePlate = new GameObject("NamePlate");
        namePlate.AddComponent<TextMesh>();            
                                                       
        TextMesh textMesh = namePlate.GetComponent<TextMesh>();
        if (textMesh != null)
        {
            textMesh.transform.position = transform.position + new Vector3(0, 1.3f, 0);
            textMesh.transform.rotation = transform.rotation;
            textMesh.characterSize = 0.4f;
            //textMesh.fontSize = 20;
            textMesh.alignment = TextAlignment.Center;
            textMesh.anchor = TextAnchor.MiddleCenter;
            textMesh.color = Color.black;
            textMesh.text = name;     
        }
        namePlate.transform.parent = transform;
    }
}
