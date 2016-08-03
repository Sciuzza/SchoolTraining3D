using UnityEngine;
using System.Collections;

public class TestCoroutine : MonoBehaviour {

	void Start ()
    {
        //StartCoroutine(SayCiaoForever());
        //StartCoroutine(SayCiaoAfterSeconds(2));
        //StartCoroutine(SayCiaoEverySeconds(1));
        //StartCoroutine(SayCiaoTenTimes(1));
        StartCoroutine(DoSomeStuff());

        int v;
        DoStuff(out v);
    }

    void DoStuff(out int a)
    {
        a = 2;
    }

    IEnumerator SayCiaoForever()
    {
        // Esegue fino a questa istruzione, poi aspetta il frame successivo, 
        // poi esegue il resto
        yield return null;  // Salta al prossimo frame

        while (true)
        {
            Debug.Log("CIAO");
            yield return null; // Salta al prossimo frame
        }
    }

    IEnumerator SayCiaoAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        Debug.Log("CIAO");
    }

    IEnumerator SayCiaoEverySeconds(int seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("CIAO");
        }
    }

    IEnumerator SayCiaoTenTimes(int seconds)
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("CIAO");
            count++;

            if (count == 10)
            {
                yield break;
            }
        }

    }

    IEnumerator DoSomeStuff()
    {
        // Diciamo ciao dopo 2 secondi
        yield return StartCoroutine(SayCiaoAfterSeconds(2));

        // Diciamo "E BASTA CIAO"
        Debug.Log("E BASTA CIAO");

        // Diciamo "scusa..." dopo 3 secondi
        yield return new WaitForSeconds(3);

        Debug.Log("scusa...");
    }

}
