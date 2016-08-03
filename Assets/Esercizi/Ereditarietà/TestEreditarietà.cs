using UnityEngine;
using System.Collections;

public class TestEreditarietà : MonoBehaviour {

	void Start () {

        Animal a = new Dog();
        a.SayVerso();


        /*
        Duck d = new Duck();
        d.SayVerso();
        Debug.Log(d.life);

        Dog dog = new Dog();
        dog.SayVerso();
        int dogLife = dog.life;


        // Creo un oggetto di tipo Duck
        // lo metto in una variabile di tipo Animal
        Animal a = null;
        if (Random.value > 0.5f) // 50%
        {
            a = new Duck();
        } else
        {
            a = new Dog();
        }

        a.SayVerso();
        int animalLife = a.life;

        if (a is Duck)
        {
            Duck d2 = (Duck)a;
            d2.Dance();
        }
        */
	}
	
}
