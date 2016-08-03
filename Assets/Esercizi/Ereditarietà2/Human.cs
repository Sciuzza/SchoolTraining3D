
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public class Human : Creature
    {
        protected override void SetupVisuals()
        {
            sr.color = new Color(1, 0.6f, 0.6f);
        }

        protected override void SetupStats()
        {
            lifePoints = 10;
        }
    }

}