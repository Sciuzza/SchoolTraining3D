using UnityEngine;
using System.Collections;


public class PropertyPlayer
{
    private int health;
    private int experience;

    private GameObject testGo;

    public virtual int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 100;
        }
    }

    private int[] statistics = new int[5];

    public int Difficulty
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < statistics.Length; i++)
            {
                sum += statistics[i];
            }
            return sum;
        }
    }



    public GameObject TestGameObject
    {
        get
        {
            if (testGo == null)
            {
                testGo = new GameObject("Test");
            }
            return testGo;
        }
    }

}



public class ChildPlayer : PropertyPlayer
{
    public override int Health
    {
        get
        {
            return 10;
        }
    }
}


public class TestProperty : MonoBehaviour {

	void Start () {
        PropertyPlayer pp = new PropertyPlayer();
        pp.Health = 10;
        Debug.Log("Health is " + pp.Health);

        GameObject go = pp.TestGameObject;
        go = pp.TestGameObject;
	}
}
