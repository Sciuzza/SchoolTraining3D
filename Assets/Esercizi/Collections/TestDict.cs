using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestDict : MonoBehaviour {

    void Start () {
        Dictionary<string, int> bankDict = new Dictionary<string, int>();

        // Popoliamo il dizionario
        bankDict.Add("Ciro", 1000);
        bankDict.Add("Carlo", 10000);
        bankDict.Add("Marco", 40000);
        bankDict["David"] = 10;

        // Retrieval di un valore
        int davidMoney = bankDict["David"];

        // Check di una chiave
        if (bankDict.ContainsKey("Marco"))
        {
            Debug.Log("Marco has " + bankDict["Marco"]);
        }

        // Check di un valore
        if (bankDict.ContainsValue(10))
        {
            Debug.Log("Esiste qualcuno che ha 10 dollari");
        }

        // Itero su ogni chiave e restituisco chiave + valore
        // ATTENZIONE: l'ordine in una hashtable non è GARANTITO in alcun modo
        foreach (string k in bankDict.Keys)
        {
            Debug.Log("Dict has the key: " + k + " with value " + bankDict[k]);
        }

        foreach(int v in bankDict.Values)
        {
            Debug.Log("Dict has value " + v);
        }

        foreach(KeyValuePair<string,int> pippo in bankDict)
        {
           string k = pippo.Key;
           int v = pippo.Value;
        }

        // Puliamo il dizionario
        bankDict.Clear();

    }

}
