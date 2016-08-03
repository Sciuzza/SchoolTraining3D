using UnityEngine;
using System.Collections;

public class Variabili1 : MonoBehaviour {
	void Start () {
        // START LOGIC

        // Let's define some variables
        int a = 0;
        int b = a;
        Debug.Log(b);

        // We do some operations
        b = a + 5;
        b = b - 3;
        Debug.Log(b);

        b *= 10;
        Debug.Log(b);

        // Complex expression
        int exp = a + b * b - a / b;
        exp = a + (b * b) - (a / b);
        exp = (a + b) * b - (a / b);
        Debug.Log(exp);

        // Casting
        float f1 = 1.0000f;
        int i1 = (int)f1;
        Debug.Log("f1 castato ad int è: " + i1);

        // y = mx + q
        int m = 10, q = -5;
        float y;

        float x = 12;



        // END LOGIC
    }
}
