using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {

    public float CurDamage;
    public float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>() != null)
        {
            other.gameObject.GetComponent<EnemyHealth>().Health -= CurDamage * Time.deltaTime;
            GameUI.Points += Time.deltaTime * 10;
        }
    }
}