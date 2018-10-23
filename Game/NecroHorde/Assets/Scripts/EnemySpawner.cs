using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    EnemyWaveController EWC; //stores the wave controller for easy variable calling UNUSED
    public GameObject[] Enemies; //stores a range of different enemies

    public void SpawnEnemy(int Wave) //called by the enemy wave spawner
    {
        

        for (int spawned = 0; spawned < Wave; spawned++) //spawns an enemy for each wave that has passed
        {
            Instantiate(Enemies[Random.Range(0, Enemies.Length)],
                gameObject.transform); //chooses a random enemy to spawn
        }
    }
}