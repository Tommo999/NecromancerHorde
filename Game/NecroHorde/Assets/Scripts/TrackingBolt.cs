using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingBolt : MonoBehaviour {

    float ShortestDistance = 15;
    public float Damage;
    GameObject ClosestEnemy;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 15);
	}

    private void FixedUpdate()
    {
        if(EnemyTracker.Enemies != null)
        foreach (GameObject Enemy in EnemyTracker.Enemies)
        {
                if (Enemy != null)
                if(Vector3.Distance(this.transform.position, Enemy.transform.position) < ShortestDistance)
                {
                    ShortestDistance = Vector3.Distance(this.transform.position, Enemy.transform.position);
                    ClosestEnemy = Enemy;
                }
        }

        if (ClosestEnemy == null)
            ShortestDistance = 15;

        if (ClosestEnemy != null)
            transform.position = Vector3.MoveTowards(transform.position, ClosestEnemy.transform.position, .25f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyHealth>() != null)
        {
            other.GetComponent<EnemyHealth>().Health -= Damage;
            Destroy(gameObject);
        }
        
    }
}
