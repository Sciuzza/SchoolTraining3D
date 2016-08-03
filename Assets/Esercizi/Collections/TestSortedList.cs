using UnityEngine;
using System.Collections.Generic;

public class TestSortedList : MonoBehaviour {

    public enum MyEnum
    {
        Uno,
        Due,
        Tre
    }

	void Start () {
        SortedList<MyEnum, string> mySortedList = new SortedList<MyEnum, string>();

        // Aggiungiamo dei valori
        mySortedList.Add(MyEnum.Due, "DUE");
        mySortedList.Add(MyEnum.Tre, "TRE");
        mySortedList[MyEnum.Uno] = "UNO";

        // Cicliamo sui valori
        Debug.Log("Index of UNO: " + mySortedList.IndexOfKey(MyEnum.Uno));

        foreach(var pair in mySortedList)
        {
            Debug.Log("K: " + pair.Key + " V: " + pair.Value);
        }

        var k = mySortedList.Keys[2];
        Debug.Log(k);

        mySortedList.Remove(MyEnum.Tre);
	}
	
}
