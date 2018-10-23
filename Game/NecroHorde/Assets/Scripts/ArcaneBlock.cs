using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 15); //destroys this block after 15 seconds
	}

    private void OnTriggerEnter(Collider other) //activates when collidig with something
    {
        if (other.gameObject.GetComponent<ArcaneBlock>() == null) //makes it so other arcane blocks dont register
        {
            if (other.gameObject.GetComponent<PlayerHealth>() != null) //makes sure it is the player being detected
            {
                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(5); //makes the player take 5 damage
            }
        }
    }
}
