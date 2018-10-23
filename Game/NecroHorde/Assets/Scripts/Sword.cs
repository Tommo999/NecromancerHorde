using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Sword : MonoBehaviour {

    Animator SwordAnimator; //stores the sword animation
    public int Damage = 75; //stores the damage of the swing

	// Use this for initialization
	void Start () {
        SwordAnimator = gameObject.GetComponent<Animator>(); //finds and stores the animation
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) //activates when left click is pressed
        {
            SwordAnimator.SetBool("IsSwinging", true); //starts the swinging animation
        }
        else
        {
            SwordAnimator.SetBool("IsSwinging", false); //stops the swinging animation
        }
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.GetComponent<EnemyHealth>()) //ativates when collided with an object that has the enemy health script
        {
            collision.gameObject.GetComponent<EnemyHealth>().Health -= Damage; //takes the enemies health
            GameUI.Points += 10; //gives the player points
        }
    }
}
