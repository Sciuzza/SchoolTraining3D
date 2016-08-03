using UnityEngine;
using System.Collections;

public class Calcolatrice : MonoBehaviour {

    public int valore1 = 0;
    public int valore2 = 0;

	void Update () {

        // Il programma ci può salutare
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("CIAO");
        }

        // Addizione
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //int result = valore1 + valore2;
        //Debug.Log("Il risultato dell'addizione è " + result);
        //}

        // Switch case per fare le operazioni
        string inputString = Input.inputString;

        if (inputString.Length > 0)
        {
            char inputChar = inputString[0];

            float result = 0;
            switch (inputChar)
            {
                case 'p':
                    result = valore1 + valore2;
                    break;

                case 'm':
                    result = valore1 - valore2;
                    break;

                case 'o':
                    result = valore1 * valore2;
                    break;

                case 'd':
                    result = (float)valore1 / valore2;
                    break;
            }
            Debug.Log("Il risultato è " + result);

        }

	}

}
