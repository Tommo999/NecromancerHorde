using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningMagic : MonoBehaviour
{

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;
    float baseWalkSpeed;
    float baseRunSpeed;

    public Rigidbody LightningBolt;
    public float ConjureVelocity = 100;
    public Transform BoltSpawnPos;
    public float Spread;
    public float ManaDrainPoint;
    public float ManaDrain;
    public PlayerMana PM;

    private void Start()
    {
        FPC = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        baseWalkSpeed = FPC.m_WalkSpeed;
        baseRunSpeed = FPC.m_RunSpeed;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && PM.mana > 0 && Time.time > ManaDrainPoint + 1.5f)
        {
            Fire();
            PM.mana -= ManaDrain * Time.deltaTime;
            FPC.m_WalkSpeed = 0;
            FPC.m_RunSpeed = 0;
        }

        if (Input.GetMouseButtonUp(0))
        {
            FPC.m_WalkSpeed = baseWalkSpeed;
            FPC.m_RunSpeed = baseRunSpeed;
        }

        if (PM.mana < 1)
        {
            ManaDrainPoint = Time.time;
        }
    }

    void Fire()
    {
        for (int BoltsSpawned = 0; BoltsSpawned < 2; BoltsSpawned++)
        {
            Rigidbody LBinstance = Instantiate(LightningBolt,
                BoltSpawnPos.position,
                BoltSpawnPos.rotation) as Rigidbody;

            LBinstance.gameObject.transform.rotation =
                new Quaternion(LBinstance.gameObject.transform.rotation.x + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.y + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.z + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.w + Random.Range(-Spread, Spread));

            LBinstance.velocity = LBinstance.transform.forward * ConjureVelocity;
        }
    }
}