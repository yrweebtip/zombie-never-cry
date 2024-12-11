using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersuarapecah : MonoBehaviour
{
    public GameObject manajersuarapecah;
    // Start is called before the first frame update
    void Start()
    {
        manajersuarapecah = GameObject.FindGameObjectWithTag("suarapecah");
        manajersuarapecah.GetComponent<efeksuarapecah>().playsuarapecah(this.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
