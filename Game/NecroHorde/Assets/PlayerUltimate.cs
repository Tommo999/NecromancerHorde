using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUltimate : MonoBehaviour
{
    public Slider UltimateSlider; //stores the sliger UI

    public float UltimateAmount; //the amount of ultimate stored
    public int MaxUltimate; //the maximum amount of ultimate
    public float UltimateRegenRate; //the regen rate of the ultimate

    private void Start()
    {
        UltimateAmount = 0; //sets the amount of ultimate to 0
    }

    private void Update()
    {
        UltimateSlider.value = UltimateAmount; //updates the ultimate slider
        if (UltimateAmount < MaxUltimate) //activates when there is less ultimate than the maximum
        {
            UltimateAmount += UltimateRegenRate * Time.deltaTime; //adds ultimate to the pool
        }
    }
}