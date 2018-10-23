using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows use of the slider

public class PlayerHealth : MonoBehaviour {

    public Slider healthSlider; //the slider on the UI for how much health the player has

    public float health; // the players current health
    public int maxhealth; //the maximum health the player can have
    public float healthRegenRate;

    public float lastTimeHit; //the last time health has been taken from the player

    private void Start()
    {
        health = maxhealth; //makes the current health equal to the maximum health
    }

    private void Update()
    {
        healthSlider.value = health; //sets the slider to reflect health percentage
        if(health <= 0) //will activate when the player dies
        {
            Time.timeScale = 0; //Pauses time
            Destroy(gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>()); //Destroys the players movement script disabling all movement
            Cursor.lockState = CursorLockMode.None; //Lets you move the cursor freely
            Cursor.visible = true; //makes the cursor visible
            FindObjectOfType<GameUI>().Gameover(); //Calls the game over method in the game ui
        }

        if (lastTimeHit < Time.time - 10 && health < 100) //will activate 10 seconds after the player is hit and the player has less than 100 health
        {
            health += healthRegenRate * Time.deltaTime; //Regenerates health 10 seconds after being hit
        }
    }

    public void TakeDamage(float DamageTaken) //method used to take health from the player
    {
        health -= DamageTaken; //takes away health from the player
        lastTimeHit = Time.time; //records when the player was hit last
    }
}