using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneBeamSpawner : MonoBehaviour {

    public float FireRate = .5f; //the wait between beam spawns
    float LastTimeFired; //the last time a beam was fired
    public float ConjureVelocity; //the speed at which the beams travel

    public Rigidbody ArcaneBlock; //the block prefab to be spawned
    public Transform ArcaneBlockSpawnPoint; //the transform the block is spawned at

    private void Start() //called upon initialization
    {
        ArcaneBlockSpawnPoint = this.transform; //the location the block is spawned at is set to the location of the gameobject this is attached to
    }

    // Update is called once per frame
    void Update () {
        if (Time.time > LastTimeFired + FireRate) //activates when more time has passed then when the time passed when it was last fired + the fire rate in seconds
        {
            LastTimeFired = Time.time; //sets the last time fired to the amount of seconds passed

            Rigidbody ABinstance = Instantiate(ArcaneBlock,
                ArcaneBlockSpawnPoint.position,
                ArcaneBlockSpawnPoint.rotation) as Rigidbody; //spawns the block as a rigidbody on the transform of the spawn point

            ABinstance.velocity = ArcaneBlockSpawnPoint.forward * ConjureVelocity; //moves the block forward
        }
    }
}