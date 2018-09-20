using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

    Scene ThisScene;

    private void Start()
    {
        ThisScene = SceneManager.GetActiveScene();
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(ThisScene.name);
    }
	
    public void ExitButton()
    {
        Application.Quit();
    }
}
