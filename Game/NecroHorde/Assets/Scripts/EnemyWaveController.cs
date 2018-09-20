using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWaveController : MonoBehaviour {

    public Text WaveCounter;

    public EnemySpawner[] EnemySpawners;
    int Wave = 0;
    public int KilledThisWave;

    private void Start()
    {
        EnemySpawners = FindObjectsOfType<EnemySpawner>();
    }

    private void Update()
    {
        if(KilledThisWave >= EnemySpawners.Length * Wave)
        {
            KilledThisWave = 0;
            Wave++;
            StartNewWave();
        }
    }

    private void StartNewWave()
    {
        WaveCounter.text = Wave.ToString();
        foreach (var Spawner in EnemySpawners)
        {
            Spawner.SpawnEnemy(Wave);
        }
    }
}