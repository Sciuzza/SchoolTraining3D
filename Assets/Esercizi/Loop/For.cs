using UnityEngine;
using System.Collections;


public class For : MonoBehaviour {

    public int n = 10;

	void Start () {
        // Programmino che fa la sommatoria fino a N
        int somma = 0;
        for(int i = 0; i < n; i++)
        {
            somma += i;
        }
        Debug.Log(somma);
	}
	
}
