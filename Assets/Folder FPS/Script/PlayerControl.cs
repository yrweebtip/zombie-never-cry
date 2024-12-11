using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float kecepatangerak;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            float gerak = kecepatangerak * Time.deltaTime;
            this.transform.Translate(-gerak, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            float gerak = kecepatangerak * Time.deltaTime;
            this.transform.Translate(gerak, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            float gerak = kecepatangerak * Time.deltaTime;
            this.transform.Translate(0, 0, gerak);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            float gerak = kecepatangerak * Time.deltaTime;
            this.transform.Translate(0, 0, -gerak);
        }
    }
}
