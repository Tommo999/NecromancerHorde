using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracker : MonoBehaviour {

    public static GameObject[] Enemies;
    
    private void FixedUpdate()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
}
