using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class TestEditor : MonoBehaviour {

	public void ResetIt () {
        transform.position = Vector3.zero;

        UnityEngine.Cursor.visible = false;

        GetComponent<Button>().Select();
	}

}
