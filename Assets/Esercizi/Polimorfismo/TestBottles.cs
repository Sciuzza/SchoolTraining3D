using UnityEngine;
using System.Collections;

public class TestBottles : MonoBehaviour {

	void Start () {
        Bottle a = new Bottle(5);
        Bottle b = new Bottle(10);
        Bottle c = a + b;

        int waterLevelOf_c = (int)c;

        if (c)
        {
        }
	}
	
	void Update () {
	
	}
}
