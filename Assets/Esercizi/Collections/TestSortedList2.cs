using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TestSortedList2 { 

    public class Enemy : IComparable, IComparable<Enemy>
    {
        public int level;
        public int health;
        public int strength;

        public Enemy(int _level, int _health, int _strength)
        {
            this.level = _level;
            this.health = _health;
            this.strength = _strength;
        }

        public int CompareTo(object obj)
        {
            if (obj is Enemy)
            {
                Enemy obj_enemy = (Enemy)obj;
                return level.CompareTo(obj_enemy.level);
            } else
            {
                return 0; // TODO: add an error here
            }
        }

        public int CompareTo(Enemy other)
        {
            return level.CompareTo(other.level);
        }


        public override string ToString()
        {
            return "(l" + level + ",h" + health + ",s" + strength + ")";
        }

    }

    public class EnemyComparer : IComparer<Enemy>
    {
        public int Compare(Enemy x, Enemy y)
        {
            // Controlla il livello
            int equal_value = x.level.CompareTo(y.level);   // Ritorna un valore: 0 se uguali, <0 se il primo è più piccolo, etc...
            if (equal_value == 0)
            {
                // se il livello è uguale, controlla invece la vita
                equal_value = x.health.CompareTo(y.health);
                if (equal_value == 0)
                {
                    // se la vita è uguale, controlla invece la forza
                    equal_value = x.strength.CompareTo(y.strength);
                }
            }
            return equal_value;
        }
    }


    public class TestSortedList2 : MonoBehaviour {


	    void Start () {

            SortedList<Enemy, string> enemyDescriptionsSortedList = new SortedList<Enemy, string>();

            Enemy e1 = new Enemy(1,10,3);
            Enemy e2 = new Enemy(2,5,5);
            Enemy e3 = new Enemy(3,2,4);

            enemyDescriptionsSortedList.Add(e3, "Nemico 3");
            enemyDescriptionsSortedList.Add(e2, "Nemico 2");
            enemyDescriptionsSortedList.Add(e1, "Nemico 1");

            foreach(var pair in enemyDescriptionsSortedList)
            {
                //Debug.Log(pair.Key + ": " + pair.Value);
            }



            // Ordiniamo una lista di nemici secondo un qualche criterio
            // ordine: livello -> vita -> forza
            List<Enemy> enemyList = new List<Enemy>();

            enemyList.Add(new Enemy(1, 10, 10));
            enemyList.Add(new Enemy(1, 2, 1));

            enemyList.Add(new Enemy(2, 2, 2));
            enemyList.Add(new Enemy(2, 2, 4));

            enemyList.Add(new Enemy(3, 3, 3));
            enemyList.Add(new Enemy(2, 4, 2));
            enemyList.Add(new Enemy(1, 2, 2));

            EnemyComparer comparer = new EnemyComparer();
            enemyList.Sort(comparer);

            foreach(var e in enemyList)
            {
                Debug.Log(e);
            }



        }

    }

}