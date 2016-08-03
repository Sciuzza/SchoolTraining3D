
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public class Dragon : Monster
    {
        protected override void SetupVisuals()
        {
            sr.color = new Color(1, 0.0f, 0.5f);
        }

        protected override void SetupStats()
        {
            lifePoints = 1000;
        }


        override public void DropLoot()
        {
            base.DropLoot();

            string arma = "uno spadone a due mani";
            Debug.Log(this.name + " droppa " + arma);
        }

    }

}