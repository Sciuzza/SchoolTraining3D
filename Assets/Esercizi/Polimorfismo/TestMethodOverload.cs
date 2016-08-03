using UnityEngine;
using System.Collections;

public class TestMethodOverload : MonoBehaviour {

    void Start()
    {

        int a = 2;
        int b = 3;
        int c = a + b;

        Vector3 v1 = new Vector3(0, 1, 0);
        Vector3 v2 = new Vector3(1, 0, 0);

        Vector3 v3 = v1 + v2;
        Vector3 v4 = Piu(v1, v2);

        Vector3 v5 = -v1;

        //int a = 1;
        //DoStuff(1f, 2f, "asdas");
    }

    Vector3 Piu(Vector3 a, Vector3 b)
    {
        return a + b;
    }


    void DoStuff()
    {
        Debug.Log("ZERO PRAMS");
    }

    void DoStuff(int i)
    {

        Debug.Log("INT PARAM");
    }

    int DoStuff(float i)
    {
        Debug.Log("FLOAT PARAM");
        return 0;
    }

    int DoStuff(int i, int j)
    {
        Debug.Log("int PARAM 2");
        return 0;
    }

    int DoStuff(float i, int j)
    {
        Debug.Log("int PARAM 2");
        return 0;
    }

    int DoStuff(int i, float j)
    {
        Debug.Log("int PARAM 2");
        return 0;
    }

    int DoStuff(float i, float j, string s)
    {
        Debug.Log("int PARAM 2");
        return 0;
    }
}
