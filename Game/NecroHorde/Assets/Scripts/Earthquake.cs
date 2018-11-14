using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour {

    UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;
    public PlayerHealth PH;
    public PlayerUltimate PU;

    public float SpeedMultiplier = 2;
    public float HealthMultiplier = 2;
    public GameObject Armor;

	// Use this for initialization
	void Start () {
        FPC = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        PH = FindObjectOfType<PlayerHealth>();
        PU = FindObjectOfType<PlayerUltimate>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PU.UltimateAmount >= PU.UltimateCooldown && Input.GetMouseButtonDown(0))
        {
            FPC.m_RunSpeed *= SpeedMultiplier;
            FPC.m_WalkSpeed *= SpeedMultiplier;
            Armor.SetActive(true);
            PU.UltimateAmount = 0;
            PH.maxhealth *= HealthMultiplier;
            PH.health = PH.maxhealth;
        }
	}
}
