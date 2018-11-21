using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MonoBehaviour {

    public Rigidbody FireBall; //stores the fireball prefab
    public float ConjureVelocity = 25; //decides how fast the fireball is thrown
    public Transform FireBallSpawnPos; //stores the position that the fireball is to be spawned at
    public float ManaCost; //how much mana is taken away when it is cast
    public PlayerMana PM; //allows easy access to the player mana
    float Cooldown = 0.5f;
    float TimeStamp;

    private void Update()
    {
        if(Input.GetAxis("Primary Attack") != 0 && PM.mana > ManaCost && Time.time > TimeStamp + Cooldown) //activates on left click and when there is enough mana
        {
            Fire(); //calls the fireball throwing method
            PM.mana -= ManaCost; //takes away the mana cost from the total mana pool
            TimeStamp = Time.time;
        }
    }

    void Fire()
    {
        Rigidbody FBinstance = Instantiate(FireBall,
            FireBallSpawnPos.position,
            FireBallSpawnPos.rotation) as Rigidbody; //spawns the fireball and stores it as a Rigidbody

        FBinstance.velocity = FireBallSpawnPos.forward * ConjureVelocity; //determines how fast forward the ball is thrown
    }
}