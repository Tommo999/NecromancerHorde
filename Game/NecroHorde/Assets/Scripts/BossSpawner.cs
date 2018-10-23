using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour {

    public GameObject[] Bosses; //used to store the numerous bosses
	
	public void SpawnBoss() //called by the wave controller
    {
        Instantiate(Bosses[Random.Range(0, Bosses.Length)],
            this.gameObject.transform); //spawns a random boss from the list
    }
}
