using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

    public float speed = 1f;
    public Transform targetTr;

	void Start () {
	
	}
	
	void Update ()
    {
        Vector3 distance = targetTr.position - this.transform.position;
        Vector3 direction = distance.normalized;
        transform.position = transform.position + direction * speed * Time.deltaTime;

        if (distance.magnitude < 0.1f)
        {
            transform.position = targetTr.position;
           // this.enabled = false;
        }

    }
}
