using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

    public GameObject cannonballPrefab;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cannonballGo = Instantiate(cannonballPrefab);
            cannonballGo.transform.position = this.transform.position;
            Rigidbody2D rb = cannonballGo.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right*20, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0,0,50*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -50 * Time.deltaTime);
        }
	}
}
