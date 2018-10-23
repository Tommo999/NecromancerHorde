using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allows the use of UI elements

public class GameUI : MonoBehaviour {

    public GameObject Scoreboard; //the scoreboard panel
    public GameObject GameoverScreen; //the game over panel
    public Text PointsText; //the text for the points
    public Text EliminationsText; //the text for the eliminations

    public static int Points; //the amount of points collected, static for easy access
    public static int Eliminations; //the amount of eliminations
    bool isGameover = false; //used to activate the game over menu

    private void Start()
    {
        Scoreboard.SetActive(false); //deactivates the score board
        GameoverScreen.SetActive(false); //deactivates the game over screen
    }

    void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)) //activates when tab pressed
        {
            Scoreboard.SetActive(true); //activates the score board
        }
        if(Input.GetKeyUp(KeyCode.Tab) && !isGameover) //activates when tab let go when the game isnt over
        {
            Scoreboard.SetActive(false); //deactivates the score board
        }

        PointsText.text = Points.ToString(); //the points text gets updated
        EliminationsText.text = Eliminations.ToString(); //the eliminations text gets updated
	}

    public void Gameover()
    {
        GameoverScreen.SetActive(true); //activates the game over screen
        isGameover = true; //sets it to game over
    }
}