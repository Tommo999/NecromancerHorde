using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    public Slider manaSlider;

    public float mana;
    public int maxMana;
    public float manaRegenRate;

    private void Start()
    {
        mana = maxMana;
    }

    private void Update()
    {
        manaSlider.value = mana;
        if(mana < maxMana)
        {
            mana += manaRegenRate * Time.deltaTime;
        }
    }
}