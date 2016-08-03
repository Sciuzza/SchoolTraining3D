
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public class Game : MonoBehaviour
    {

        void Start()
        {
            Creature[] allCreatures = FindObjectsOfType<Creature>();
            foreach(Creature creature in allCreatures)
            {
                Vector3 tmpPos = creature.transform.position;
                tmpPos.y = 0;
                creature.transform.position = tmpPos;

                // Let's make all monsters drop
                if (creature is Monster)
                {
                    Monster monster = (Monster)creature;
                    monster.DropLoot();
                }

            }

        }

    }

}