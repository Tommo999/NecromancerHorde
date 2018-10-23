using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 10); //destroys the object after 10 seconds
	}
}
