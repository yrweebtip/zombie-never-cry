using UnityEngine;

public class ZombieCollider : MonoBehaviour
{
    public GameObject manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag=="Peluru")
        {
            manager.GetComponent<ZombieManager>().tertembak();
            Destroy(other.gameObject);
        }
        
    }
}
