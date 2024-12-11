using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pecahincube : MonoBehaviour
{
    [SerializeField] private GameObject ObyekPengganti;
    [SerializeField] private float breakforce = 2;
    [SerializeField] private float collisionMultiplier = 0.1f;
    [SerializeField] private bool sudahpecah;
    [SerializeField] float radiusledakan = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if (sudahpecah) return;
        if (collision.relativeVelocity.magnitude >= breakforce)
        {
            sudahpecah = true;
            var obyekpecah = Instantiate(ObyekPengganti, transform.position, transform.rotation);

            var rbs = obyekpecah.GetComponentsInChildren<Rigidbody>();

            foreach(var rb in rbs)
            {
                rb.AddExplosionForce(collision.relativeVelocity.sqrMagnitude * collisionMultiplier,
                collision.contacts[0].point, radiusledakan);
            }
            Destroy(gameObject);
        }
    }
}
