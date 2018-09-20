using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MonoBehaviour {

    public Rigidbody FireBall;
    public float ConjureVelocity = 25;
    public Transform FireBallSpawnPos;
    public float ManaCost;
    public PlayerMana PM;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && PM.mana > ManaCost)
        {
            Fire();
            PM.mana -= ManaCost;
        }
    }

    void Fire()
    {
        Rigidbody FBinstance = Instantiate(FireBall,
            FireBallSpawnPos.position,
            FireBallSpawnPos.rotation) as Rigidbody;

        FBinstance.velocity = FireBallSpawnPos.forward * ConjureVelocity;
    }
}