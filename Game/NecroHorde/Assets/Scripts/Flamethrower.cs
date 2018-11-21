using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : MonoBehaviour {

    public Rigidbody Flame; //stores the flame object
    public float ConjureVelocity; //how fast the flame is thrown
    public Transform FlameSpawn; //where the flame is spawned
    public float ManaDrainPoint; //stores the time since last run out of mana
    public float ManaDrain; //how fast the mana drains
    public float FireRate;
    public float LastTimeFired;
    public PlayerMana PM; //stores the player mana script

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Primary Attack") != 0 && Time.time >= LastTimeFired + FireRate &&
            PM.mana > 0 && ManaDrainPoint < Time.time + 2)
        {
            PM.mana -= ManaDrain * Time.deltaTime;
            LastTimeFired = Time.time;
            SpawnFlame();
        }
        if (PM.mana <= 0)
        {
            ManaDrainPoint = Time.time;
        }
	}

    void SpawnFlame()
    {
        Rigidbody FlameInstance = Instantiate(Flame,
            FlameSpawn.position,
            FlameSpawn.rotation) as Rigidbody;

        FlameInstance.velocity = FlameSpawn.forward * ConjureVelocity;
    }
}
