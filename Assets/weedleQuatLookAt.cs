using UnityEngine;
using System.Collections;

public class weedleQuatLookAt : MonoBehaviour {


    public Transform targetTransform;

    public Vector3 mydir = new Vector3(1, 1, 0);
    public float myAngle = 45;

    Vector3 lookAtDirection;
    Vector3 fromDirection;
    Quaternion fromRot;


    void Awake()
    {
        fromDirection = this.transform.forward;
        fromRot = this.transform.rotation;
    }

    float t = 0.0f;
    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;

        // Direzione a cui voglio arrivare

        lookAtDirection = targetTransform.position - this.transform.position;
        lookAtDirection.Normalize();

        // Direzione da cui voglio partire
      


        // Assegno la rotazione per farmi ruotare verso Lookat
        if (fromDirection != lookAtDirection)
        {
             Quaternion quat = Quaternion.FromToRotation(fromDirection, lookAtDirection);

            Quaternion slerpQuat = Quaternion.Slerp(Quaternion.identity,quat ,t);

            transform.rotation = slerpQuat * fromRot;
        }


    }
}
