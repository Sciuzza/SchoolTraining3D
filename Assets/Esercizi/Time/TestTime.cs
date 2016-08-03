using UnityEngine;
using System.Collections;

public class TestTime : MonoBehaviour {

	void Start () {
        Debug.Log("In start il tempo è: " + Time.time);
        Time.timeScale = 1;
	}
	
	void Update () {
        Debug.Log("Update: " + Time.time  + "\n dt:" + Time.deltaTime);
        //Debug.Log("Unscaled: " + Time.unscaledTime + "\n dt:" + Time.unscaledDeltaTime);
    }

    void FixedUpdate()
    {
        Debug.LogWarning("Fixed: " + Time.fixedTime + "\n dt:" + Time.fixedDeltaTime);
    }
}
