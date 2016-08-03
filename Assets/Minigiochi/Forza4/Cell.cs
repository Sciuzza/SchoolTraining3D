using UnityEngine;
using System.Collections;

namespace Forza4
{
    public class Cell : MonoBehaviour
    {
        public int state = 0;  // 0 = vuota, 1 = x, 2 = O

        public void AssignPlayer(int player)
        {
            Grid pippoGrid = FindObjectOfType<Grid>();

            SpriteRenderer sr = GetComponent<SpriteRenderer>();

            if (player == 1)
            {
                sr.color = Color.red;
                pippoGrid.currentPlayer = 2;
            }
            else
            {
                sr.color = Color.green;
                pippoGrid.currentPlayer = 1;
            }

            state = player;

            pippoGrid.CheckWinner(this);

        }

    }
}