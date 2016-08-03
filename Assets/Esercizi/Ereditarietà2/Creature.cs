
namespace Monsters
{
    using UnityEngine;
    using System.Collections;

    public abstract class Creature : MonoBehaviour
    {
        protected int lifePoints;
        protected SpriteRenderer sr;

        void Awake()
        {
            sr = GetComponent<SpriteRenderer>();
            SetupVisuals();
            SetupStats();
        }

        protected abstract void SetupVisuals();

        protected abstract void SetupStats();
    }

}