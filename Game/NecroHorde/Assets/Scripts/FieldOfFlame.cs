using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfFlame : MonoBehaviour {

    PlayerUltimate PU;
    public Rigidbody Field;
    Transform PlayerPos;

	// Use this for initialization
	void Start () {
        PU = FindObjectOfType<PlayerUltimate>();
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(PU.UltimateAmount >= PU.UltimateCooldown && Input.GetMouseButtonDown(0))
        {
            PU.UltimateAmount = 0;
            SpawnField();
        }
	}

    void SpawnField()
    {
        Rigidbody FieldInstance = Instantiate(Field,
            new Vector3(PlayerPos.position.x,
            0, PlayerPos.position.z),
            PlayerPos.rotation) as Rigidbody;

        FieldInstance.name = "FlameTime";
    }
}
