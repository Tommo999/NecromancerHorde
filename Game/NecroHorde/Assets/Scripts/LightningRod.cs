using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningRod : MonoBehaviour {

    public Transform LightningSpawn;
    public Rigidbody LightningBolt;

    PlayerMana PM;

    public float FireRate;
    public float LastTimeFired;
    public float ManaCost;

    public int Velocity = 10;

	// Use this for initialization
	void Start () {
        PM = FindObjectOfType<PlayerMana>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Primary Attack") != 0 && LastTimeFired + FireRate <= Time.time && PM.mana > ManaCost)
        {
            Fire();
            PM.mana -= ManaCost;
            LastTimeFired = Time.time;
        }
	}

    void Fire()
    {
        Rigidbody FBinstance = Instantiate(LightningBolt,
            LightningSpawn.position,
            LightningSpawn.rotation) as Rigidbody; //spawns the fireball and stores it as a Rigidbody

        FBinstance.velocity = LightningSpawn.forward * Velocity; //determines how fast forward the ball is thrown
    }
}
