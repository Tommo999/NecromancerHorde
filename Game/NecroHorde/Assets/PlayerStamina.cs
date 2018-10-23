using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStamina : MonoBehaviour
{
    public Slider StaminaSlider; //stores the slider UI

    public float Stamina; //the amount of stamina stored
    public int MaxStamina; //the maximum amount of stamina
    public float StaminaRegenRate; //the regen rate of stamina

    private void Start()
    {
        Stamina = MaxStamina; //sets the amount of stamina to the maximum
    }

    private void Update()
    {
        StaminaSlider.value = Stamina; //updates the stamina slider
        if (Stamina < MaxStamina) //activates when there is less stamina than the maximum
        {
            Stamina += StaminaRegenRate * Time.deltaTime; //adds stamina to the pool
        }
    }
}