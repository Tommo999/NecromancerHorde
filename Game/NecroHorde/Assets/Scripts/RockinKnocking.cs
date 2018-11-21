using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockinKnocking : MonoBehaviour {

    public Animator LeftyAnim; //stores the animation of the left fist
    public Animator RightyAnim; //stores the animation of the right fist

    PlayerMana PM;

    private void Start()
    {
        PM = FindObjectOfType<PlayerMana>();
    }

    // Update is called once per frame
    void Update () {
            if (Input.GetAxis("Secondary Attack") != 0 && PM.mana >= 5) //activates when left click is pressed
            {
                LeftyAnim.SetBool("IsSwinging", true); //starts the swinging animation
            }
            else
            {
                LeftyAnim.SetBool("IsSwinging", false); //stops the swinging animation
            }

            if (Input.GetAxis("Primary Attack") != 0 && PM.mana >= 5) //activates when left click is pressed
            {
                RightyAnim.SetBool("IsSwinging", true); //starts the swinging animation
            }
            else
            {
                RightyAnim.SetBool("IsSwinging", false); //stops the swinging animation
            }
    }
}
