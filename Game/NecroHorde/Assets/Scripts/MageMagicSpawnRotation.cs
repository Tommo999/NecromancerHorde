using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMagicSpawnRotation : MonoBehaviour {

    public float RotationSpeed; //the rotation speed

	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(0, RotationSpeed * Time.deltaTime, 0)); //spins it around on the y axis
	}
}
