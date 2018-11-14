using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allows the use of UI elements

public class GameUI : MonoBehaviour {

    public GameObject PauseMenu;
    public GameObject Scoreboard; //the scoreboard panel
    public GameObject GameoverScreen; //the game over panel
    public Text PointsText; //the text for the points
    public Text EliminationsText; //the text for the eliminations

    bool GameOverDone = false;

    ClassController ClassC;
    EquipmentSwitcher ES;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController FPC;

    public static float Points; //the amount of points collected, static for easy access
    public static int Eliminations; //the amount of eliminations
    bool isGameover = false; //used to activate the game over menu
    bool isPaused = false;

    private void Start()
    {
        Scoreboard.SetActive(false); //deactivates the score board
        GameoverScreen.SetActive(false); //deactivates the game over screen

        Points = 0;
        Eliminations = 0;

        Time.timeScale = 1;

        ES = FindObjectOfType<EquipmentSwitcher>();
        ClassC = FindObjectOfType<ClassController>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!isPaused)
            {
                PauseMenu.SetActive(true);
                isPaused = true;
                Time.timeScale = 0;
                FPC.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (isPaused)
            {
                PauseMenu.SetActive(false);
                isPaused = false;
                Time.timeScale = 1;
                FPC.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab)) //activates when tab pressed
        {
            Scoreboard.SetActive(true); //activates the score board
        }
        if(Input.GetKeyUp(KeyCode.Tab) && !isGameover) //activates when tab let go when the game isnt over
        {
            Scoreboard.SetActive(false); //deactivates the score board
        }

        PointsText.text = Mathf.RoundToInt(Points).ToString(); //the points text gets updated
        EliminationsText.text = Eliminations.ToString(); //the eliminations text gets updated
	}

    public void Gameover()
    {
        GameoverScreen.SetActive(true); //activates the game over screen
        Scoreboard.SetActive(true); //activates the scoreboard
        PauseMenu.SetActive(false);
        isGameover = true; //sets it to game over

        if (!GameOverDone)
        {
            if (PlayerPrefs.HasKey("OverallKills"))
            {
                PlayerPrefs.SetInt("OverallKills", PlayerPrefs.GetInt("OverallKills") + Eliminations);
            }
            else
            {
                PlayerPrefs.SetInt("OverallKills", Eliminations);
            }
            GameOverDone = true;
        }

        ES.UnequipAll();
        ES.enabled = false;

        if (ClassC != null)
        {
            if(ClassC.ChosenClass == "Fire")
            {
                if(PlayerPrefs.HasKey("FireRounds"))
                {
                    if (EnemyWaveController.Wave > PlayerPrefs.GetInt("FireRounds"))
                    {
                        PlayerPrefs.SetInt("FireRounds", EnemyWaveController.Wave -1);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("FireRounds", EnemyWaveController.Wave -1);
                }

                if (PlayerPrefs.HasKey("FireKills"))
                {
                    if (Eliminations > PlayerPrefs.GetInt("FireKills"))
                    {
                        PlayerPrefs.SetInt("FireKills", Eliminations);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("FireKills", Eliminations);
                }
            }

            if (ClassC.ChosenClass == "Lightning")
            {
                if (PlayerPrefs.HasKey("LightningRounds"))
                {
                    if (EnemyWaveController.Wave > PlayerPrefs.GetInt("LightningRounds"))
                    {
                        PlayerPrefs.SetInt("LightningRounds", EnemyWaveController.Wave -1);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("LightningRounds", EnemyWaveController.Wave -1);
                }

                if (PlayerPrefs.HasKey("LightningKills"))
                {
                    if (Eliminations > PlayerPrefs.GetInt("LightningKills"))
                    {
                        PlayerPrefs.SetInt("LightningKills", Eliminations);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("LightningKills", Eliminations);
                }
            }

            if (ClassC.ChosenClass == "Earth")
            {
                if (PlayerPrefs.HasKey("EarthRounds"))
                {
                    if (EnemyWaveController.Wave > PlayerPrefs.GetInt("EarthRounds"))
                    {
                        PlayerPrefs.SetInt("EarthRounds", EnemyWaveController.Wave -1);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("EarthRounds", EnemyWaveController.Wave -1);
                }

                if (PlayerPrefs.HasKey("EarthKills"))
                {
                    if (Eliminations > PlayerPrefs.GetInt("EarthKills"))
                    {
                        PlayerPrefs.SetInt("EarthKills", Eliminations);
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("EarthKills", Eliminations);
                }
            }
        }
    }
}