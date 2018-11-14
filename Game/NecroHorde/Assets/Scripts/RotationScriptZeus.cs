using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScriptZeus : MonoBehaviour {

    public float Speed = 1;
    public float Multiplier = 2;
    
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            gameObject.transform.Rotate(new Vector3(Speed, Speed, Speed) * Multiplier);
        }
        else
        {
            gameObject.transform.Rotate(new Vector3(Speed, Speed, Speed));
        }
	}
}
