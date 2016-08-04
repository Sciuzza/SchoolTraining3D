using UnityEngine;
using System.Collections;

public class weedleCont : MonoBehaviour {

	void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name.Contains("Pokeball"))
        {
            Destroy(obj.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        this.transform.localPosition += this.transform.forward * 2 * Time.deltaTime;
    }
}
