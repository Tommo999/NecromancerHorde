using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBolt : MonoBehaviour {

    public int Damage = 100; //the amount of damage

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, .2f); //destroys the object after .2 seconds
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>()) //activates when it hits an enemy
        {
            collision.gameObject.GetComponent<EnemyHealth>().Health -= Damage; //takes away the damage from the enemy health
            Destroy(gameObject); //destroys the object
            GameUI.Points += 3; //adds 3 points to the total points
        }
        if (!collision.gameObject.GetComponent<LightningBolt>()) //activates when it hits something that isnt a lightning bolt
        {
            Destroy(gameObject); //destroys the object
        }
    }
}