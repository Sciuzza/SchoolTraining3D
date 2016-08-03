using UnityEngine;
using System.Collections;

// Script che fa in modo che quando questo oggetto tocca qualcosa, ESPLODE.
public class CollisionHandler : MonoBehaviour {

    // Questo metodo viene chiamato quando questo oggetto collide con qualcosa d'altro (other)
    // ATTENZIONE. servono un RB e un Collider.
    public void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("AHIA");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(coll.contacts[0].normal * 6, ForceMode2D.Impulse);
    }


}
