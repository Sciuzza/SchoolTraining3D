using UnityEngine;
using System.Collections;

namespace Exceptions
{
    public class TestCell
    {
        private GameObject go;

        public void SetGameobjectName(string s)
        {
            throw new System.IndexOutOfRangeException("FREGATO");
            go.name = s;
        }
    }


    public class ExceptionTest : MonoBehaviour
    {
        void Awake()
        {
            TestCell testCell = new TestCell();
            try { 
                testCell.SetGameobjectName("Ciao");
            } 
            catch(System.NullReferenceException e)
            {
                Debug.LogWarning("Attenzione, testCell ha un gameobject NULL" + e.StackTrace);
            }
            catch(System.IndexOutOfRangeException e)
            {
                Debug.LogWarning(e.Message);
            }

            Debug.Log("CIAO");
        }

    }

}