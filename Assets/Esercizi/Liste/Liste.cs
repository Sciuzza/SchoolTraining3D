using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Liste : MonoBehaviour {

	void Start () {

        // Creo una lista dinamica di interi
        List<int> listaInt = new List<int>();

        // Aggiungo un elemento alla lista
        listaInt.Add(5);
        listaInt.Add(3);


        // Aggiungo il contenuto di un array alla lista
        int[] tmpList = new int[3] { 1, 2, 3 };
        listaInt.AddRange(tmpList);

        // Inserisco un valore in mezzo
        listaInt.Insert(2, 7);

        // Rimuove il valore 7 dalla lista
        listaInt.Remove(7);

        // Rimuove il primo valore
        listaInt.RemoveAt(0);

        // C'è un sette?
        if (listaInt.Contains(7))
        {
            Debug.Log("SETTE");
        }

        // Reversa la lista
        listaInt.Reverse();

        // Ordina la lista
        listaInt.Sort();

        // Per ogni elemento
        foreach(int v in listaInt)
        {
            Debug.Log(v);
        }

        // Printiamo il contenuto della lista
        for (int i = 0; i < listaInt.Count; i++)
        {
           // Debug.Log(listaInt[i]);
        }

        // Svuota la lista
        listaInt.Clear();

    }

    void Update () {
	
	}
}
