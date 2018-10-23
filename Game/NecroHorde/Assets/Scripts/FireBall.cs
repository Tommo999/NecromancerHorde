using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    public int Damage = 100; //the damage that the fireball does

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5); //destroys the gameobject after 5 seconds
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>()) //activates if the collided object has a enemy health script
        {
            collision.gameObject.GetComponent<EnemyHealth>().Health -= Damage; //takes the damage away from the health of the enemy
            GameUI.Points += 10; //adds 10 points to the total points
        }
        Destroy(gameObject); //destroys the attached object
    }
}