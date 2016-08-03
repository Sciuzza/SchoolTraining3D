using UnityEngine;
using System.Collections;

public class MyClass : MonoBehaviour {

    public int myNum = 0;

    private static int Count = 0;

	void Start ()
    {
        MyStatic.ciaoString = "MUORI";
        MyStatic.SayCiao();

        MyClass.Count++;
        Debug.Log(MyClass.Count);

        MyClass.SayNum(this);
    }

    static void SayNum(MyClass whatClass)
    {
        Debug.Log(whatClass.myNum);
    }
	
}
