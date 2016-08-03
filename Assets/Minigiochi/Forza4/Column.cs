using UnityEngine;
using System.Collections;

namespace Forza4
{
    public class Column : MonoBehaviour
    {
        public Cell[] cells;

        public void SetCellNumber(int n)
        {
            cells = new Cell[n];
        }

        void OnMouseUp()
        {
            // Cerco la grid
            Grid pippoGrid = FindObjectOfType<Grid>();

            // Quando clicco una colonna...

            // Controllo in ordine le sue celle
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].state == 0) {
                    cells[i].AssignPlayer(pippoGrid.currentPlayer);
                    break;
                }
            }
        }


    }
}