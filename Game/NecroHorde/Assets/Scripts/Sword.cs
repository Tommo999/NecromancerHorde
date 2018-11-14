using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Sword : MonoBehaviour {

    Animator SwordAnimator; //stores the sword animation
    PlayerStamina PS;
    public int Damage = 75; //stores the damage of the swing
    public float StaminaDrain;
    bool SwordSwung;

	// Use this for initialization
	void Start () {
        SwordAnimator = gameObject.GetComponent<Animator>(); //finds and stores the animation
        PS = FindObjectOfType<PlayerStamina>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && PS.Stamina > StaminaDrain) //activates when left click is pressed
        {
            SwordAnimator.SetBool("IsSwinging", true); //starts the swinging animation
            SwordSwung = true;
        }
        else
        {
            SwordAnimator.SetBool("IsSwinging", false); //stops the swinging animation
        }
        
        if(gameObject.GetComponent<BoxCollider>() != null && SwordSwung == true)
        {
            PS.Stamina -= StaminaDrain;
            SwordSwung = false;
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
