using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{

    public float life = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Destroy(this.gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pasif")
        {
            //Destroy(this.gameObject);
            Vector3 bekaspeluru = collision.contacts[0].point;
            GameObject bekastembakan;
//bekastembakan = GameObject.CreatePrimitive(PrimitiveType.Cube);
//bekastembakan.transform.position = bekaspeluru;

        } else
        {
            //Destroy(collision.gameObject);
            //Destroy(this.gameObject);
        }
        
    }
}
