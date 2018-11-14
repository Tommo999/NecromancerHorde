using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OraOraRotation : MonoBehaviour {

    public float MaxSpeed;
    public float MinSpeed;
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(
            Random.Range(MinSpeed, MaxSpeed),
            Random.Range(MinSpeed, MaxSpeed),
            Random.Range(MinSpeed, MaxSpeed)) * Time.deltaTime);
    }
}
