using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Slider healthSlider;

    public int health;
    public int maxhealth;

    private void Start()
    {
        health = maxhealth;
    }

    private void Update()
    {
        healthSlider.value = health;
        if(health <= 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>());
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            FindObjectOfType<GameUI>().Gameover();
        }
    }
}
