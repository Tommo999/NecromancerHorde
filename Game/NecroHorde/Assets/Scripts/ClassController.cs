using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController : MonoBehaviour {

    public string ChosenClass = "Fire";

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectOfType<ClassController>() != gameObject.GetComponent<ClassController>())
        {
            Destroy(gameObject);
        }
    }
}
