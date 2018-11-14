using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

    public float SpeedMultiplier;
    UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;

	// Use this for initialization
	void Start () {
        
	}

    private void OnEnable()
    {
        FPC = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        FPC.m_WalkSpeed *= SpeedMultiplier;
        FPC.m_RunSpeed *= SpeedMultiplier;
    }

    private void OnDisable()
    {
        FPC.m_WalkSpeed /= SpeedMultiplier;
        FPC.m_RunSpeed /= SpeedMultiplier;
    }
}
