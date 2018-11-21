using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeus : MonoBehaviour {

    PlayerUltimate PU;
    public GameObject ZeusBeam;

    // Use this for initialization
    void Start () {
        PU = FindObjectOfType<PlayerUltimate>();
        ZeusBeam.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(PU.UltimateAmount >= PU.UltimateCooldown && Input.GetAxis("Primary Attack") != 0)
        {
            ZeusBeam.SetActive(true);
            PU.UltimateAmount = 0;
        }
	}
}