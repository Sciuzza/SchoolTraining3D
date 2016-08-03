using UnityEngine;
using System;


public class TestArray : MonoBehaviour {

	void Start () {
        int[] builtin_array = new int[4];

        System.Array arr = Array.CreateInstance(typeof(int), 4);
        foreach(var element in arr)
        {

        }

        Array.Sort(builtin_array);

    }
	
	void Update () {
	
	}
}
