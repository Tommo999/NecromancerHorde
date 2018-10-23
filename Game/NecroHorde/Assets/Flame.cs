using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {

    public float SizeIncreaseMulti;
    public float DamageIncreaseMulti;
    public float MaxDamage;
    public float MinDamage;
    public float CurDamage;
    public float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
        CurDamage = MaxDamage;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>() != null)
        {
            other.gameObject.GetComponent<EnemyHealth>().Health -= CurDamage * Time.deltaTime;
        }
    }
}