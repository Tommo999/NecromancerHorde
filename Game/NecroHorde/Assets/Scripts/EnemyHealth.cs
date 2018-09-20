using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int MaxHealth = 100;
    public int Health;

    EnemyWaveController EWC;

	// Use this for initialization
	void Start () {
        Health = MaxHealth;
        EWC = FindObjectOfType<EnemyWaveController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0)
        {
            Destroy(gameObject);
            EWC.KilledThisWave++;
            GameUI.Eliminations++;
        }
	}
}
