using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMagic : MonoBehaviour {

    public GameObject Wall;
    public Transform WallSpawnPos;
    public float ManaCost;
    public PlayerMana PM;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && PM.mana > ManaCost)
        {
            Fire();
            PM.mana -= ManaCost;
        }
    }

    void Fire()
    {
        GameObject WallInstance = Instantiate(Wall,
            new Vector3(WallSpawnPos.position.x, 1, WallSpawnPos.position.z),
            new Quaternion(WallSpawnPos.rotation.x * 0, WallSpawnPos.rotation.y,
            WallSpawnPos.rotation.z * 0, WallSpawnPos.rotation.w));
    }
}
