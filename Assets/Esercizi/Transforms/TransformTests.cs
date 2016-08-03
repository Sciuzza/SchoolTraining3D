using UnityEngine;
using System.Collections;

public class TransformTests : MonoBehaviour {

	void Start () {
        //transform.localPosition = new Vector3(0, 0, 0);
        //transform.position = new Vector3(0, 0, 0);

        //transform.localEulerAngles = new Vector3(0, 0, 90);
        //transform.eulerAngles = new Vector3(0, 0, 90);

        //transform.localScale = new Vector3(2, 2, 2);
        //transform.lossyScale = new Vector3(3, 3, 3);

/*
        Vector3 globalRight = Vector3.right;
        Vector3 globalUp = Vector3.up;

        Vector3 localRight = transform.right;
        Vector3 localUp = transform.up;

        transform.position += localRight * 2;
        transform.Translate(2, 2, 0);

        transform.Rotate(0, 0, 90);*/

        Transform t = transform.Find("A");
       // Debug.Log(t);

        Transform p = transform.parent;
       // Debug.Log(transform.GetChild(2));

        int count = transform.childCount;

        // Reparenting
        //transform.SetParent(p);
        transform.SetAsFirstSibling();
        transform.SetAsLastSibling();
        transform.SetSiblingIndex(4);

        // Prende tutti i figli
        foreach (Transform tr in transform)
        {
            Debug.Log(tr);
        }

        transform.LookAt(Vector3.zero);
        transform.Rotate(0, -90, 0);
    }

    void Update () {
	
	}
}
