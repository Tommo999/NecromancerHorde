using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    EnemyWaveController EWC;
    public GameObject[] Enemies;

    private void Start()
    {
    }

    public void SpawnEnemy(int Wave)
    {
        for (int spawned = 0; spawned < Wave; spawned++)
        {
            Instantiate(Enemies[Random.Range(0, Enemies.Length)],
                gameObject.transform);
        }
    }
}