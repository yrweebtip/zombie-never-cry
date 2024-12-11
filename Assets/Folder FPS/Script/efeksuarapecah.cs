using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efeksuarapecah : MonoBehaviour
{
    public AudioSource[] suarapecah;
    public int i;
    Vector3 lokasipecah;
    void Start()
    {
        suarapecah= GetComponentsInChildren<AudioSource>();

    }
    void Update()
    {
        if (i == suarapecah.Length) { i = 0; }
    }
    void putaraudio(int nomorarray,Vector3 lokasipecah)
    {
        if(nomorarray>=0 && nomorarray<suarapecah.Length)
        {
            suarapecah[nomorarray].transform.position = lokasipecah;
            suarapecah[nomorarray].Play();
        }
    }

    public void playsuarapecah(Vector3 posisi)
    {
        putaraudio(i, posisi);
        i++;
    }
}
