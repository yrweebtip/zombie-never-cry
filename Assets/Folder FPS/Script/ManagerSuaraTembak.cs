using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSuaraTembak: MonoBehaviour
{
    public AudioSource[] suaratembak;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        suaratembak = GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(i == suaratembak.Length) { i = 0; }
    }

    void putaraudio(int nomorarray)
    {
        if (nomorarray >= 0 && nomorarray < suaratembak.Length)
        {
            suaratembak[nomorarray].Play();
        }
    }
    public void tembak()
    {
        putaraudio(i);
        i++;
    }
}
