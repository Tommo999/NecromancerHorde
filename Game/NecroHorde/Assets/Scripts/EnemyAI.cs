using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    public static Transform PlayerTrans;
    NavMeshAgent NMA;
    Animator ArmAnim;

    private void Start()
    {
        NMA = gameObject.GetComponent<NavMeshAgent>();
        ArmAnim = gameObject.GetComponentInChildren<Animator>();
    }

    private void FixedUpdate()
    {
        if (PlayerTrans != null)
        {
            gameObject.transform.LookAt(PlayerTrans);
            NMA.SetDestination(PlayerTrans.position);
        }
    }

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, PlayerTrans.position) <= 1.75)
        {
            ArmAnim.SetBool("CloseToPlayer", true);
        }
        else
        {
            ArmAnim.SetBool("CloseToPlayer", false);
        }
    }
}
