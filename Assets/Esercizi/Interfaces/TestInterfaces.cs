using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

// Qualsiasi classe che implementa questa interfaccia può essere 'testata'
public interface ITestable
{
    void TestIt();
}

public interface IPickupable
{
    void PickUp();
    int Weight { get; }
}

public class MyTest1 : ITestable, IPickupable
{
    public int Weight
    {
        get
        {
            return 5;
        }
    }

    public void PickUp()
    {
        Debug.Log("Preso da terra");
    }

    public void TestIt()
    {
        Debug.Log("MyTest1: testing done!");
    }
}

public class MyTest2 : ITestable
{
    public void TestIt()
    {
        Debug.Log("MyTest2: testing done!");
    }
}


public class MyStupidList : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        yield return 0;
        yield return 2;
        yield return 5;
    }
}


public class TestInterfaces : MonoBehaviour {

	void Start () {
       /* MyTest1 t1 = new MyTest1();
        t1.TestIt();

        MyTest2 t2 = new MyTest2();
        t2.TestIt();

        List<ITestable> testableList = new List<ITestable>();
        testableList.Add(t1);
        testableList.Add(t2);


        foreach (var testableItem in testableList)
        {
            testableItem.TestIt();
        }


        t1.PickUp();
        Debug.Log(t1.Weight);*/






        // Usiamo la nostra lista stupida
        MyStupidList list = new MyStupidList();
        foreach (int item in list)
        {
            Debug.Log(item);
        }

	}
	
	void Update () {
	
	}
}
