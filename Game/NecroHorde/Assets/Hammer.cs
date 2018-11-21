using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    Animator SwordAnimator; //stores the sword animation
    PlayerStamina PS;
    public float StaminaDrain;
    bool SwordSwung;
    bool m_isAxisInUse;

    public GameObject HammerWall;
    public Transform WallSpawnPos;

    // Use this for initialization
    void Start () {
        SwordAnimator = gameObject.GetComponent<Animator>(); //finds and stores the animation
        PS = FindObjectOfType<PlayerStamina>();
    }
	
	// Update is called once per frame
	void Update () {
        SwordAnimator.SetBool("IsWalling", false); //stops the swinging animation
        if (Input.GetAxisRaw("Secondary Attack") != 0)
        {
            if (m_isAxisInUse == false)
            {
                if (PS.Stamina > StaminaDrain) //activates when left click is pressed
                {
                    SwordAnimator.SetBool("IsWalling", true); //starts the swinging animation
                    PS.Stamina -= StaminaDrain;
                }
                else
                {
                    SwordAnimator.SetBool("IsWalling", false); //stops the swinging animation
                }
                m_isAxisInUse = true;
            }
        }
        if (Input.GetAxisRaw("Secondary Attack") == 0)
        {
            m_isAxisInUse = false;
        }
    }

    public void WallUp()
    {
        Instantiate(HammerWall,
            new Vector3(WallSpawnPos.position.x, 1, WallSpawnPos.position.z),
            new Quaternion(WallSpawnPos.rotation.x * 0, WallSpawnPos.rotation.y,
            WallSpawnPos.rotation.z * 0, WallSpawnPos.rotation.w)); //spawns a wall


    }
}
