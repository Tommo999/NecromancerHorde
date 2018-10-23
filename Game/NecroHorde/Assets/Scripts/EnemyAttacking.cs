using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour {

    public int Damage = 10; //how much damage the enemy does

    private void OnTriggerEnter(Collider collision) //activates when colliding with another game object
    {
        //Verifies you are hitting the player
        if (collision.gameObject.GetComponent<PlayerHealth>())
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(Damage); //Takes health away from player
        }
    }
}