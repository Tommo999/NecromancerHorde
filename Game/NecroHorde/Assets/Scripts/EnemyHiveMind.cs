using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHiveMind : MonoBehaviour {

    public EnemyAI EnemyAI; //stores the enemy AI position
    public GameObject Player; //stores the players gameobject

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player"); //finds the player
        EnemyAI.PlayerTrans = Player.transform; //sets the enemy's destination to the players position
    }

    private void FixedUpdate()
    {
        EnemyAI.PlayerTrans = Player.transform; //sets the enemy's destination to the players position
    }

}
