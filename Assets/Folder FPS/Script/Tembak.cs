using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{

    public Transform bulletspawn;
    public GameObject bulletprefab;
    public float kecPeluru;
    public GameObject manajersuara;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletprefab, bulletspawn.position, bulletspawn.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = bulletspawn.forward * kecPeluru;
            manajersuara.GetComponent<ManagerSuaraTembak>().tembak();
        
        }
    }

 

}
