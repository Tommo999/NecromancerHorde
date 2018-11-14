using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    Scene ThisScene; //stores the current scene for reloading
    Scene MainMenu; //stores the main menu scene

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;
    public GameObject PauseMenu;

    private void Start()
    {
        ThisScene = SceneManager.GetActiveScene(); //assigns the current scene
    }

    public void RestartButton() //called when the restart button is pressed
    {
        Time.timeScale = 1; //sets the timescale to normal speed
        SceneManager.LoadScene(ThisScene.name); //used to reload the scene
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        FPC.enabled = true;
        PauseMenu.SetActive(false);
    }
	
    public void ExitButton() //called when the exit button is pressed
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0); //Loads the main menu
    }
}
