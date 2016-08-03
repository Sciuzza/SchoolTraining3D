using UnityEngine;
using System.Collections;

namespace Tris
{
    public class Cell : MonoBehaviour
    {
        public int state = 0;  // 0 = vuota, 1 = x, 2 = O

        void OnMouseUp()
        {
            Debug.Log("Hai premuto " + gameObject.name);

            if(state == 0)  // Se la cella è vuota
            {
                Grid pippoGrid = FindObjectOfType<Grid>();

                if (pippoGrid.currentPlayer == 1)   // Se il giocatore è X
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.color = Color.red;
                    state = 1;
                    pippoGrid.currentPlayer = 2;
                    

                }
                else  // Se il giocatore è O
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.color = Color.green;
                    state = 2;
                    pippoGrid.currentPlayer = 1;
                }

                pippoGrid.CheckWinner();
            }
        }

    }

}