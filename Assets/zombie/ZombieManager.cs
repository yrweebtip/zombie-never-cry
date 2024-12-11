using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class ZombieManager : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;
    public int nyawamax;
    public int nyawaact;
    Animator animasi;
    int tewas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animasi = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        agent.speed = 1.0f;
        nyawaact = nyawamax;
        animasi.Play("berjalan", 0, Random.Range(0f, 1f));
       // animasi.SetTrigger("jalan");
        //animasi.ResetTrigger("jalan");
        tewas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        if (nyawaact == 0 && tewas ==0)
        {
            agent.speed = 0f;
            
            animasi.ResetTrigger("jalan");
            animasi.SetTrigger("death");
            tewas = 1;
        }
    }
    public void tertembak()
    {
        if (nyawaact >0 && nyawaact<=nyawamax)
        {
            nyawaact--;
        }
    }
}
