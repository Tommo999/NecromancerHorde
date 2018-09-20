using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Sword : MonoBehaviour {

    Animator SwordAnimator;
    public int Damage = 75;

	// Use this for initialization
	void Start () {
        SwordAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SwordAnimator.SetBool("IsSwinging", true);
        }
        else
        {
            SwordAnimator.SetBool("IsSwinging", false);
        }
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<EnemyHealth>().Health -= Damage;
        }
    }
}
