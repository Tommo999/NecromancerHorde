using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    public Slider manaSlider; //stores the sliger UI

    public float mana; //the amount of mana stored
    public int maxMana; //the maximum amount of damage
    public float manaRegenRate; //the regen rate of mana

    private void Start()
    {
        mana = maxMana; //sets the amount of mana to the maximum
    }

    private void Update()
    {
        manaSlider.value = mana; //updates the mana slider
        if(mana < maxMana) //activates when there is less mana than the maximum
        {
            mana += manaRegenRate * Time.deltaTime; //adds mana to the pool
        }
    }
}