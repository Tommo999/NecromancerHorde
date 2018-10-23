using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int MaxHealth = 100; //the maximum health the enemy can have
    public float Health; //the enemy's current health

    EnemyWaveController EWC; //used to record amount of enemies killed per wave

	// Use this for initialization
	void Start () {
        Health = MaxHealth; //the current health is set to the maximum amount
        EWC = FindObjectOfType<EnemyWaveController>(); //assigns the variable a script
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0 && gameObject.tag == "Enemy") //activates when a normal enemy falls below 0 health
        {
            Destroy(gameObject); //destroys the gameobject this is attached to
            EWC.KilledThisWave++; //used to track how many enemies are killed and when to start a new wave
            GameUI.Eliminations++; //used for scoring on the UI
            GameUI.Points += 5; //gives player a small amount of points
        }

        if (Health <= 0 && gameObject.tag == "Boss") //activates when a boss falls below 0 health
        {
            Destroy(gameObject); //destroys the gameobject this is attached to
            EWC.BossKilled = true; //tells the wave controller to start a new wave
            GameUI.Eliminations++; //used for scoring on the UI
            GameUI.Points += 50; //gives player a large amount of points
        }
    }
}