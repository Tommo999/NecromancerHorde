using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //needed for the enemy AI

public class EnemyAI : MonoBehaviour {

    public static Transform PlayerTrans; //the players position, same for all enemies
    NavMeshAgent NMA; //the agent used for navigation for the maze
    Animator ArmAnim; //the animator used for attacking the player

    private void Start()
    {
        NMA = gameObject.GetComponent<NavMeshAgent>(); //assigns the variable
        ArmAnim = gameObject.GetComponentInChildren<Animator>(); //assigns the variable
    }

    private void FixedUpdate()
    {
        if (PlayerTrans != null) //makes sure that the player is detected for no errors
        {
            gameObject.transform.LookAt(PlayerTrans); //makes the enemy look at the player
            NMA.SetDestination(PlayerTrans.position); //sets the AI's destination to the players location
        }
    }

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, PlayerTrans.position) <= 1.75) //activates when the player is within 1.75m
        {
            ArmAnim.SetBool("CloseToPlayer", true); //Activates the attacking animation
        }
        else
        {
            ArmAnim.SetBool("CloseToPlayer", false); //Activates the idle animation
        }
    }
}
