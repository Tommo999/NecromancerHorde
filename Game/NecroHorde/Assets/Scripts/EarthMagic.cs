using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMagic : MonoBehaviour {

    public GameObject Wall; //the wall gameobject
    public Transform WallSpawnPos; //the position the wall is spawning at
    public float ManaCost; //the amount of mana the wall will cost
    public PlayerMana PM; //the script for the player mana

    private void Update()
    {
        if (Input.GetAxis("Primary Attack") != 0 && PM.mana > ManaCost) //activates when there is more mana than the cost and the left click is pressed down
        {
            Fire(); //activates the fire method
            PM.mana -= ManaCost; //subtracts the mana cost from the total mana
        }
    }

    void Fire() //the method used to spawn the wall
    {
        Instantiate(Wall,
            new Vector3(WallSpawnPos.position.x, 1, WallSpawnPos.position.z),
            new Quaternion(WallSpawnPos.rotation.x * 0, WallSpawnPos.rotation.y,
            WallSpawnPos.rotation.z * 0, WallSpawnPos.rotation.w)); //spawns a wall
    }
}