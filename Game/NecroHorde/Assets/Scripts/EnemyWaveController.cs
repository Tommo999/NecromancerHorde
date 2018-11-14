using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows use of the UI system

public class EnemyWaveController : MonoBehaviour {

    public Text WaveCounter; //stores the wave counter

    public BossSpawner BS; //stores the bosses spawner
    public EnemySpawner[] EnemySpawners; //stores the enemy spawner scripts
    public static int Wave = 0; //stores the wave
    public int KilledThisWave; //stores how many enemies have been killed
    public bool BossKilled; //activates when the boss is killed
    public bool BossSpawned; //activates when the boss is spawned

    public bool BossSystemOn = true; //

    private void Start()
    {
        EnemySpawners = FindObjectsOfType<EnemySpawner>(); //assigns the enemy spawners to the variable
        BS = FindObjectOfType<BossSpawner>(); //assigns the boss spawners to the variable

        Wave = 0;
        KilledThisWave = 0;
    }

    private void Update()
    {
        if (BossSystemOn) //activates when the boss system is turned on
        {
            if (KilledThisWave >= EnemySpawners.Length * Wave && !BossSpawned) //spawns the boss after all the enemies were killed
            {
                BossSpawned = true; //tells the script that the boss spawned
                KilledThisWave = 0; //resets the amount of enemies killed
                BS.SpawnBoss(); //tells the boss spawner to spawn the boss
            }

            if (BossKilled) //activates the next wave
            {
                Wave++; //starts next wave
                BossKilled = false; //resets the boss stuff
                BossSpawned = false; //resets the boss stuff
                StartNewWave(); //calls method below
            }
        }
        if (!BossSystemOn) //activates when boss system off
        {
            if (KilledThisWave >= EnemySpawners.Length * Wave) //activates when the enemies are killed
            {
                Wave++; //adds 1 to wave
                StartNewWave(); //starts the new wave
                KilledThisWave = 0; //resets the amount of enemies killed
            }
        }
    }

    private void StartNewWave() //does the required things to start a new wave
    {
        WaveCounter.text = Wave.ToString(); //updates the UI
        foreach (var Spawner in EnemySpawners) //goes through every spawner
        {
            Spawner.SpawnEnemy(Wave); //calls a method and sets the enemies to spawn to the wave amount
        }
    }
}