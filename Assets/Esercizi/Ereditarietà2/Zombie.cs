
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public class Zombie : Monster
    {
        protected override void SetupVisuals()
        {
            sr.color = new Color(0.0f, 0.3f, 0.0f);
        }

        protected override void SetupStats()
        {
            lifePoints = 5;
        }
    }

}