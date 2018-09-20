using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHiveMind : MonoBehaviour {

    public EnemyAI EnemyAI;
    public GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        EnemyAI.PlayerTrans = Player.transform;
    }

    private void FixedUpdate()
    {
        EnemyAI.PlayerTrans = Player.transform;
    }

}
