using UnityEngine;

public class Duck : Animal
{
    override public void SayVerso()
    {
        Debug.Log("QUACK");
    }

    public void Dance()
    {
        Debug.Log("Duck is dancing");
    }

}
