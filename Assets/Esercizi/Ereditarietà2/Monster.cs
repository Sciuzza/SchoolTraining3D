
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public abstract class Monster : Creature
    {
        virtual public void DropLoot()
        {
            int money = Random.Range(1, 5) * 100;
            Debug.Log(this.name + " droppa " + money + "$");
        }

    }

}