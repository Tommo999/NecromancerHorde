using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour {

    public int Damage = 10;
    public float lastTimeDamaged;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>())
        {
            lastTimeDamaged = Time.time;
            //Debug.Log(collision.name);
            collision.gameObject.GetComponent<PlayerHealth>().health -= Damage;
            Debug.Log(collision.gameObject.GetComponent<PlayerHealth>().health);
        }
    }
}