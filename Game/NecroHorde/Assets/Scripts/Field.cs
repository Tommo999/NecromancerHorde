using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {

    public float Damage;
    public float Lifetime;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, Lifetime);
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>() != null)
        {
            other.gameObject.GetComponent<EnemyHealth>().Health -= Damage * Time.deltaTime;
            PlayerPrefs.SetFloat("UltimateDamage", Damage * Time.deltaTime);
        }
    }
}
