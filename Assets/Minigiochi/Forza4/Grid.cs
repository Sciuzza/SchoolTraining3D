using UnityEngine;
using System.Collections;

namespace Forza4
{

    public class Grid : MonoBehaviour
    {
        public int currentPlayer = 1;

        public int n_rows = 6;
        public int n_cols = 7;

        public int offset_x = -4;
        public int offset_y = 3;

        GameObject cellprefabToSpawn;    // Cella di 'base' da copiare e incollare
        public GameObject columnPrefabToSpawn;  // Colonna di 'base' da copiare e incollare

        private GameObject[] columnGos;

        private Cell[,] cellGrid;

        void Start()
        {
            cellprefabToSpawn = Resources.Load<GameObject>("Cristiano/CellPrefab");

            // Crea le colonne
            columnGos = new GameObject[n_cols];
            for (int i = 0; i < n_cols; i++)
            {
                GameObject newColumnGo = Instantiate(columnPrefabToSpawn);
                newColumnGo.transform.position = new Vector3(i + offset_x, 0, 0);
                newColumnGo.name = "Column " + i;
                columnGos[i] = newColumnGo;

                // Dico alla colonna che ha N celle
                Column col = newColumnGo.GetComponent<Column>();
                col.SetCellNumber(n_rows);
            }
            Destroy(columnPrefabToSpawn);


            // Crea 6x7 celle
            cellGrid = new Cell[n_rows, n_cols];
            for (int i = 0; i < n_rows; i++)
            {
                for (int j = 0; j < n_cols; j++)
                {
                    // Crea una cella e posizionala (e dagli un nome)
                    GameObject newCellGo;
                    newCellGo = Instantiate(cellprefabToSpawn);
                    newCellGo.transform.position = new Vector3(j + offset_x, i + offset_y, 0);
                    newCellGo.name = "Cell " + i + " " + j;

                    // Metto la cella creata nella colonna corrispondente
                    GameObject columnGo = columnGos[j];
                    Column column = columnGo.GetComponent<Column>();
                    Cell[] cells = column.cells;
                    Cell cellToPlace = newCellGo.GetComponent<Cell>();
                    cells[i] = cellToPlace;

                    cellGrid[i, j] = cellToPlace;
                }
            }
        }

        public void CheckWinner(Cell newCell)
        {
            // Cerchiamo la newCell nella nostra griglia
            int new_i = 0, new_j = 0;
            bool found_new_cell = false;
            for (int i = 0; i < n_rows; i++)
            {
                for (int j = 0; j < n_cols; j++)
                {
                    if (cellGrid[i, j] == newCell)
                    {
                        new_i = i;
                        new_j = j;
                        found_new_cell = true;
                        break;
                    }
                }

                if (found_new_cell)
                    break;
            }


            // prendiamo il giocatore di quella cella
            int player = newCell.state;

            // Definisco le 4 direzioni
            Vector2[] directions = new Vector2[4];
            directions[0] = new Vector2(-1, -1);
            directions[1] = new Vector2(0, -1);
            directions[2] = new Vector2(1, -1);
            directions[3] = new Vector2(1, 0);

            // Per ogni direzione
            foreach (Vector2 dir in directions)
            {
                // Continuo nella direzione finché posso
                int nUguali = 1;
                Vector2 tmpDir = dir;
                while(CheckCell(new_i, new_j, tmpDir, player))
                {
                    nUguali++;
                    tmpDir += dir;
                }

                tmpDir = -dir;
                while(CheckCell(new_i, new_j, tmpDir, player))
                {
                    nUguali++;
                    tmpDir += -dir;
                }

                if (nUguali >= 4)
                {
                    Debug.Log("HAI VINTO GIOCATORE " + player);
                    break;
                }
            }


        }


        private bool CheckCell(int new_i, int new_j, Vector2 dir, int player)
        {
            int target_i = new_i + (int)dir.x;
            int target_j = new_j + (int)dir.y;

            if (target_i < 0)
                return false;

            if (target_j < 0)
                return false;

            if (target_i >= n_rows)
                return false;

            if (target_j >= n_cols)
                return false;

            return cellGrid[target_i, target_j].state == player;
        }

    }

 }