using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBolt : MonoBehaviour {

    public int Damage = 100;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, .2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().Health -= Damage;
            Destroy(gameObject);
            GameUI.Points += 3;
        }
        if (!collision.gameObject.GetComponent<LightningBolt>())
        {
            Destroy(gameObject);
        }
    }
}