using UnityEngine;
using System.Collections;

public class LogicaCondizionale1 : MonoBehaviour {

    public int valoreCheInseriamo;

	void Start () {
        int a = 0;
        int b = 3;
        while(a < b)
        {
            a++;
        }


        // Esempio: sempre vero
        if (true)
        {
            Debug.Log("SEMPRE VERO - ESEGUITA SEMPRE");
        }

        // Esempio: sempre falso
        if (false)
        {
            Debug.Log("SEMPRE FALSO - MAI ESEGUITA");
        }

        // Controlliamo di aver inserito il valore giusto
        int valoreGiusto = 5;
        int valoreInserito = valoreCheInseriamo;

        if (valoreGiusto == valoreInserito)
        {
            Debug.Log("BRAVO! HAI INSERITO IL VALORE GIUSTO");
        }
        else if (valoreInserito == 42)
        {
            Debug.Log("ADDIO E GRAZIE PER TUTTI I PESCI");
        }
        else { 
            Debug.Log("CHE SCHIFO HAI SBAGLIATO");
        }
    }

}
