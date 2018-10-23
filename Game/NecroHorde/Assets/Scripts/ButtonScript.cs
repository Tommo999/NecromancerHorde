using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    Scene ThisScene; //stores the current scene for reloading

    private void Start()
    {
        ThisScene = SceneManager.GetActiveScene(); //assigns the current scene
    }

    public void RestartButton() //called when the restart button is pressed
    {
        Time.timeScale = 1; //sets the timescale to normal speed
        SceneManager.LoadScene(ThisScene.name); //used to reload the scene
    }
	
    public void ExitButton() //called when the exit button is pressed
    {
        Application.Quit(); //Quits the application when it is a full build
    }
}
