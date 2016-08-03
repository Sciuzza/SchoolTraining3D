using UnityEngine;
using System.Collections;

public class TestInput : MonoBehaviour {

    public SpriteRenderer sr;

    [Range(0,1)]
    public float myx;

	void Update () {

        /*if (Input.GetButton("Jump"))
        {
            sr.color = Color.green;
        } else
        {
            sr.color = Color.red;
        }*/

        float x = Input.GetAxis("Horizontal");
        sr.color = Color.Lerp(Color.red, Color.blue, x);
        sr.transform.position = Vector3.Lerp(Vector3.zero, Vector3.one, x);

	}
}
