using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public GameObject Scoreboard;
    public GameObject GameoverScreen;
    public Text PointsText;
    public Text EliminationsText;

    public static int Points;
    public static int Eliminations;
    bool isGameover = false;

    private void Start()
    {
        Scoreboard.SetActive(false);
        GameoverScreen.SetActive(false);
    }

    void Update () {
		if(Input.GetKeyDown(KeyCode.Tab))
        {
            Scoreboard.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.Tab) && !isGameover)
        {
            Scoreboard.SetActive(false);
        }

        PointsText.text = Points.ToString();
        EliminationsText.text = Eliminations.ToString();
	}

    public void Gameover()
    {
        GameoverScreen.SetActive(true);
        isGameover = true;
    }
}