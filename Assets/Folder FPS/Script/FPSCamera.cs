using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public GameObject kapsul;
    public float skalagerak;
    float kecepatanV, kecepatanH, atasbawah, kirikanan;
    // Start is called before the first frame update
    void Start()
    {
        kecepatanV = 2f;
        kecepatanH = 2f;
        kirikanan = this.transform.eulerAngles.y;
        atasbawah = this.transform.eulerAngles.x;

        kapsul.transform.Rotate(0, this.transform.rotation.y, 0);
    }

    // Update is called once per frame
    void Update()
    {

        kirikanan += kecepatanH * Input.GetAxis("Mouse X")*skalagerak;
        atasbawah += kecepatanV * Input.GetAxis("Mouse Y")*skalagerak;
        
        this.transform.eulerAngles= new Vector3(-atasbawah, kirikanan, 0);

        this.transform.parent = kapsul.transform;
        kapsul.transform.eulerAngles = new Vector3(0, kirikanan, 0);
    }



}

