using UnityEngine;
using System.Collections;

public class BinaryConverter : MonoBehaviour {
	void Start () {
        // START LOGIC

        // We create an algorithm that will convert a binary number to an integer
        // WARNING: we do so only for 8 bits

        int bit0 = 1;
        int bit1 = 0;
        int bit2 = 0;
        int bit3 = 0;
        int bit4 = 0;
        int bit5 = 0;
        int bit6 = 0;
        int bit7 = 1;

        float number = 
              Mathf.Pow(2, 0) * bit0
            + Mathf.Pow(2, 1) * bit1
            + Mathf.Pow(2, 2) * bit2
            + Mathf.Pow(2, 3) * bit3
            + Mathf.Pow(2, 4) * bit4
            + Mathf.Pow(2, 5) * bit5
            + Mathf.Pow(2, 6) * bit6
            + Mathf.Pow(2, 7) * bit7
            ;

        Debug.Log(number);


        // Creare un programma che, dato un prezzo in euro (530.70) restituisca il numero di banconote
        // usando pezzi da 50, 20 e 5 euro, e il resto a parte.

        // END LOGIC
    }
}
