using UnityEngine;
using System.Collections;


// Giochino che indovina un numero
public class IndovinaIlNumero : MonoBehaviour {

    int numeroChePensaIlComputer;
    int inf = 0;
    int sup = 100;

	void Start () {
        numeroChePensaIlComputer = (inf + sup) / 2;
        Debug.Log("Secondo il mio modesto parere, tu stai pensando al numero " + numeroChePensaIlComputer);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Se il numero è minore
            sup = numeroChePensaIlComputer;
            numeroChePensaIlComputer = (inf + sup) / 2;
            Debug.Log("Secondo il mio modesto parere, tu stai pensando al numero " + numeroChePensaIlComputer);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Se il numero è maggiore
            inf = numeroChePensaIlComputer;
            numeroChePensaIlComputer = (inf + sup) / 2;
            Debug.Log("Secondo il mio modesto parere, tu stai pensando al numero " + numeroChePensaIlComputer);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Se il numero è uguale
            Debug.Log("EVVIVA HO INDOVINATO");
        }
    }
	
}
