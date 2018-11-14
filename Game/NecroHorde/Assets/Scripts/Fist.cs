using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour {
    
    public float Damage = 50;
    public float ManaCost = 5;
    public PlayerMana PM;

    private void Start()
    {
        PM = FindObjectOfType<PlayerMana>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>() != null)
        {
            other.gameObject.GetComponent<EnemyHealth>().Health -= Damage;
            PM.mana -= ManaCost;
        }
    }
}
