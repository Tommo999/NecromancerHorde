using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (FindObjectOfType<AudioSource>() != gameObject.GetComponent<AudioSource>())
        {
            Destroy(gameObject);
        }
	}
}
