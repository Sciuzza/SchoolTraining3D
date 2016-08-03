using UnityEngine;
using System.Collections;

public class Statistics
{
    private int health;
    private int strength;
    private int agility;
    private int luck;

    public int Health
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

    public int this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return health; 
                case 1: return strength; 
                case 2: return agility; 
                case 3: return luck; 
            }
            return 0;
        }
        set
        {

        }
    }
}


public class TextIndexer : MonoBehaviour {

	void Start () {
        Statistics st = new Statistics();
        Debug.Log("Health is " + st[0]);
	}
	
}
