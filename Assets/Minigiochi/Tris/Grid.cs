using UnityEngine;
using System.Collections;

namespace Tris { 

    // Create the 3x3 grid
    public class Grid : MonoBehaviour {

        // Variabili
        public int currentPlayer = 1;
        int[,] grid = new int[3, 3];
        public GameObject prefabToSpawn;   // Qui dentro c'è CellPrefab dalla nostra scena

        // Metodi
	    void Start () {

            // Crea 3x3 celle
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    // Crea una cella e posizionala (e dagli un nome)
                    GameObject newCell;
                    newCell = Instantiate(prefabToSpawn);
                    newCell.transform.position = new Vector3(j, -i, 0);
                    newCell.name = "Cell " + i + " " + j;
                }
            }
            Destroy(prefabToSpawn);

	    }

        public void CheckWinner()
        {
            // Prende tutte le celle
            Cell[] allCells = FindObjectsOfType<Cell>();
            //for (int i = 0; i < allCells.Length; i++)
            //{
            //Debug.Log("La cella " + i + " è " + allCells[i].name);
            //}

            // Controlla la riga in alto
            int result = DidSomeoneWin(allCells[8].state, allCells[7].state, allCells[6].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla la riga al centro
            result = DidSomeoneWin(allCells[5].state, allCells[4].state, allCells[3].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla la riga in basso
            result = DidSomeoneWin(allCells[2].state, allCells[1].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla la colonna a sinistra
            result = DidSomeoneWin(allCells[8].state, allCells[5].state, allCells[2].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla la colonna al centro
            result = DidSomeoneWin(allCells[7].state, allCells[4].state, allCells[1].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla la colonna a destra
            result = DidSomeoneWin(allCells[6].state, allCells[3].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }


            // Controlla la diagonale principale
            result = DidSomeoneWin(allCells[8].state, allCells[4].state, allCells[0].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Controlla l'altra diagonole
            result = DidSomeoneWin(allCells[6].state, allCells[4].state, allCells[2].state);
            if (result > 0)
            {
                Debug.Log("Ha vinto il giocatore " + result);
                return;
            }

            // Se siamo qui, nessuno ha vinto finora
            // Allora, controlliamo se c'è una parità
            int productForDraw = 1;
            for (int i = 0; i < allCells.Length; i++)
            {
                productForDraw *= allCells[i].state;
            }

            if (productForDraw > 0)
            {
                Debug.Log("NON HA VINTO NESSUNO! PARITà");
            }

        }

        private int DidSomeoneWin(int v1, int v2, int v3)
        {
            int product = v1 * v2 * v3;

            // Se esce zero, nessuno ha vinto
            if (product == 0)
            {
                return 0;
            }
            // Se esce 1, ha vinto giocatore 1
            else if (product == 1)
            {
                return 1;
            } 
            // Se esce 8, ha vinto il 2
            else if (product == 8)
            {
                return 2;
            }
            // Altrimenti non ha vinto nessuno
            else
            {
                return 0;
            }
        }


    }

}