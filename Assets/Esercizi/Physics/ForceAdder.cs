using UnityEngine;
using System.Collections;

public class ForceAdder : MonoBehaviour {

    public int upStrength = 1;    // La macchina accelera
    public int downStrength = -1;  // La macchina decelera (frena)
    public Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(1,1) * 5, ForceMode2D.Impulse);
	}

    public bool isAccelerating;
    public bool isDecelerating;

    void Update()
    {
        isAccelerating = Input.GetKey(KeyCode.W);
        isDecelerating = Input.GetKey(KeyCode.S);
    }

    void FixedUpdate() {
        //rb.AddForce(-Physics2D.gravity * rb.mass);

        if (isAccelerating)
        {
            rb.AddForce(Vector2.up * upStrength);
        }
        else if (isDecelerating)
        {
            rb.AddForce(Vector2.up * downStrength);
        } 
    }


}
