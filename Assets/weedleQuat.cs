using UnityEngine;
using System.Collections;

public class weedleQuat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Vector3 mydir = new Vector3(1, 1, 0);
    public float myAngle = 45;

    float t = 0.0f;
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime;

       

        Quaternion quat = Quaternion.AngleAxis(myAngle * t, mydir);

        transform.rotation = quat;


	}
}
