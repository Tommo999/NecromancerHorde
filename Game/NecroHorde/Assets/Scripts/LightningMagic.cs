using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningMagic : MonoBehaviour
{

    UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC; //stores the player movement script
    float baseWalkSpeed; //stores the normal walk speed
    float baseRunSpeed; //stores the normal run speed

    public Rigidbody LightningBolt; //stores the lightning bolt object
    public float ConjureVelocity = 100; //how fast the bolt is thrown
    public Transform BoltSpawnPos; //where the bolt is spawned
    public float Spread; //how far out the bolts spread
    public float ManaDrainPoint; //stores the time since last run out of mana
    public float ManaDrain; //how fast the mana drains
    public PlayerMana PM; //stores the player mana script

    private void Start()
    {
        FPC = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>(); //finds and stores the player movement
        baseWalkSpeed = FPC.m_WalkSpeed; //stores the normal walk speed
        baseRunSpeed = FPC.m_RunSpeed; //stores the normal run speed
    }

    private void Update()
    {
        if (Input.GetAxis("Primary Attack") != 0 && PM.mana > 0 && Time.time > ManaDrainPoint + 1.5f) //activates when mouse button pressed down
        {
            Fire(); //fires the lightning magic
            PM.mana -= ManaDrain * Time.deltaTime; //takes away mana at a constant rate
            FPC.m_WalkSpeed = 0; //sets the walk speed to 0
            FPC.m_RunSpeed = 0; //sets the run speed to 0
        }

        if (Input.GetAxis("Primary Attack") == 0) //activates when left click let go of
        {
            FPC.m_WalkSpeed = baseWalkSpeed; //resets the walk speed
            FPC.m_RunSpeed = baseRunSpeed; //resets the run speed
        }

        if (PM.mana < 1) //activates when theres less than one mana
        {
            ManaDrainPoint = Time.time; //sets the mana drain point
        }
    }

    private void OnDisable() //resets the run speed
    {
        if (FPC != null)
        {
            FPC.m_WalkSpeed = baseWalkSpeed; //resets the walk speeds
            FPC.m_RunSpeed = baseRunSpeed; //resets the run speeds
        }
    }

    void Fire()
    {
        for (int BoltsSpawned = 0; BoltsSpawned < 2; BoltsSpawned++) //activates three times
        {
            Rigidbody LBinstance = Instantiate(LightningBolt,
                BoltSpawnPos.position,
                BoltSpawnPos.rotation) as Rigidbody; //spawns the rigidbody

            LBinstance.gameObject.transform.rotation =
                new Quaternion(LBinstance.gameObject.transform.rotation.x + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.y + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.z + Random.Range(-Spread, Spread),
                LBinstance.gameObject.transform.rotation.w + Random.Range(-Spread, Spread)); //adds the spread

            LBinstance.velocity = LBinstance.transform.forward * ConjureVelocity; //shoots the lightning forward
        }
    }
}