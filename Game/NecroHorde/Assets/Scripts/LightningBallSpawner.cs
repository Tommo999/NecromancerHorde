using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBallSpawner : MonoBehaviour {

    public Rigidbody LightningBolt;
    public int Velocity = 1;

    // Use this for initialization
    void Start() {
        StartCoroutine("SpawnBalls");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>())
        SpawnTheBalls();
    }

    public void SpawnTheBalls()
    {
        for (int BallsSpawned = 0; BallsSpawned < 5; BallsSpawned++)
        {
            Fire();
            this.gameObject.transform.Rotate(0, 72, 0);
        }
        StartCoroutine("DestroyThis");
    }
	
	IEnumerator SpawnBalls()
    {
        yield return new WaitForSeconds(1);
        SpawnTheBalls();
    }

    void Fire()
    {
        Rigidbody LBinstance = Instantiate(LightningBolt,
            this.transform.position + (this.transform.forward * 2),
            this.transform.rotation) as Rigidbody; //spawns the fireball and stores it as a Rigidbody

        LBinstance.velocity = LBinstance.transform.forward * Velocity; //determines how fast forward the ball is thrown
    }

    IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(.05f);
        Destroy(gameObject);
    }
}
