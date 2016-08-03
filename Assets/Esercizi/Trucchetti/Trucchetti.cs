using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Trucchetto pericoloso number 1
using MyBigStringOfAwesomeness = System.String;
using PlayerLevel = System.Int32;
using StringList = System.Collections.Generic.List<System.String>;

public class Trucchetti : MonoBehaviour {

	void Start () {

        string[] stringsArray = new string[5];
        stringsArray[0] = "CIAO";
        stringsArray[1] = "AAA";
        stringsArray[2] = "BBB";
        stringsArray[3] = "FEFE";
        stringsArray[4] = "CECFACA";

        // Trucchetto pericoloso number 2
        foreach (var s in stringsArray)
        {
            Debug.Log(s);
        }

        var i1 = 0;
        var i2 = 0.0;
        var i3 = i1 + (float)i2;


        var tmpPos = transform.position;


        // Trucchetto pericoloso numero 3:
        // Parametri di default
        //int sum = AddNumbers(2, 5);
        //int sum2 = AddNumbers(2, 4, c:3, bool1:true);

        // Trucchetto pericolos numero 4:
        // Lista di parametri di numero indefinito
        int a = 5;
        int b = 3;
        int c = 6;
        int sum3 = AddNumbers(a);

        // TRucchetto PERICOLOSISSIMO numero 5
        int r;
        int d;
        //SuperDivision(5, 2, out d, out r);
    }


    /*int AddNumbers(int a, int b, int c = 0, bool verbose = false, bool bool1 = true, bool bool2 = false)
    {
        if (verbose) Debug.Log("STO SOMMANDO " + a + " + " + b + " + " + c);
        return a + b + c;
    }*/


    int AddNumbers(int v1, int v2 = 0, params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }


    //void SuperDivision(out int a, int b, out int div, out int resto)
    //{
    //resto = a % b;
    // div = a / b;
    //}
}
