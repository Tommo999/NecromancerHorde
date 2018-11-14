using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreAndUnlockController : MonoBehaviour {
    
    public Button LightningButton;
    public Button EarthButton;

    public Button FlamingGS;
    public Button StrangeDagger;
    public Button RockShield;
    public Button DesertEagle;

    public GameObject AreYouSure;

    public InputField CodeInput;
    public string CorrectCode = "150118";
    public Text CodeResultText;

    //Highest Round Texts
    public Text FireRounds;
    public Text LightningRounds;
    public Text EarthRounds;

    //Highest Kills Text
    public Text FireKills;
    public Text LightningKills;
    public Text EarthKills;

    //Other Texts
    public Text UltimateKills;
    public Text OverallKills;

    //Reset All Confirmation Buttons
    
	// Use this for initialization
	void Start () {
        #region ScoreSetting
        if (PlayerPrefs.HasKey("FireRounds"))
        {
            FireRounds.text = PlayerPrefs.GetInt("FireRounds").ToString();
        }
        else
        {
            FireRounds.text = 0.ToString();
        }

        if (PlayerPrefs.HasKey("LightningRounds"))
        {
            LightningRounds.text = PlayerPrefs.GetInt("LightningRounds").ToString();
        }
        else
        {
            LightningRounds.text = 0.ToString();
        }

        if (PlayerPrefs.HasKey("EarthRounds"))
        {
            EarthRounds.text = PlayerPrefs.GetInt("EarthRounds").ToString();
        }
        else
        {
            EarthRounds.text = 0.ToString();
        }
        

        if (PlayerPrefs.HasKey("FireKills"))
        {
            FireKills.text = PlayerPrefs.GetInt("FireKills").ToString();
        }
        else
        {
            FireKills.text = 0.ToString();
        }

        if (PlayerPrefs.HasKey("LightningKills"))
        {
            LightningKills.text = PlayerPrefs.GetInt("LightningKills").ToString();
        }
        else
        {
            LightningKills.text = 0.ToString();
        }

        if (PlayerPrefs.HasKey("EarthKills"))
        {
            EarthKills.text = PlayerPrefs.GetInt("EarthKills").ToString();
        }
        else
        {
            EarthKills.text = 0.ToString();
        }


        if (PlayerPrefs.HasKey("UltimateDamage"))
        {
            UltimateKills.text = Mathf.RoundToInt(PlayerPrefs.GetFloat("UltimateDamage")).ToString();
        }
        else
        {
            UltimateKills.text = 0.ToString();
        }

        if(PlayerPrefs.HasKey("OverallKills"))
        {
            OverallKills.text = PlayerPrefs.GetInt("OverallKills").ToString();
        }
        else
        {
            OverallKills.text = 0.ToString();
        }
        #endregion

        #region Unlocks
        //Unlock Electricity
        if (PlayerPrefs.HasKey("FireKills"))
        {
            if (PlayerPrefs.GetInt("FireKills") >= 250)
            {
                LightningButton.interactable = true;
            }
        }

        if (PlayerPrefs.HasKey("EarthKills"))
        {
            if (PlayerPrefs.GetInt("EarthKills") >= 250)
            {
                LightningButton.interactable = true;
            }
        }

        //Unlock Earth
        if(PlayerPrefs.HasKey("UltimateDamage"))
        {
            if (PlayerPrefs.GetFloat("UltimateDamage") >= 5000)
            {
                EarthButton.interactable = true;
            }
        }

        //Unlock Weapons
            //Unlock Flaming Greatsword
            if (PlayerPrefs.HasKey("FireRounds"))
            {
                if (PlayerPrefs.GetInt("FireRounds") >= 20)
                {
                    FlamingGS.interactable = true;
                }
            }

            //Unlock Strange Dagger
            if (PlayerPrefs.HasKey("ElectricityRounds"))
            {
                if (PlayerPrefs.GetInt("ElectricityRounds") >= 20)
                {
                    StrangeDagger.interactable = true;
                }
            }

            //Unlock Rock Shield
            if (PlayerPrefs.HasKey("EarthRounds"))
            {
                if (PlayerPrefs.GetInt("EarthRounds") >= 20)
                {
                    RockShield.interactable = true;
                }
            }

            //Unlock Deagle
            if (PlayerPrefs.HasKey("CodeUnlocked"))
            {
                DesertEagle.interactable = true;
            }
        
        #endregion
    }

    public void ResetButton()
    {
        AreYouSure.SetActive(true);
    }

    public void CodeEntered()
    {
        if (CodeInput.text == CorrectCode)
        {
            PlayerPrefs.SetInt("CodeUnlocked", 0);
            CodeResultText.text = "Desert Eagle Unlocked";
            DesertEagle.interactable = true;
        }
        else
        {
            CodeResultText.text = "Incorrect Code";
        }
    }

    public void ResetAll()
    {
        PlayerPrefs.DeleteAll();

        AreYouSure.SetActive(false);

        LightningButton.interactable = false;
        EarthButton.interactable = false;

        FlamingGS.interactable = false;
        StrangeDagger.interactable = false;
        RockShield.interactable = false;
        DesertEagle.interactable = false;

        FireRounds.text = 0.ToString();
        LightningRounds.text = 0.ToString();
        EarthRounds.text = 0.ToString();

        FireKills.text = 0.ToString();
        LightningKills.text = 0.ToString();
        EarthKills.text = 0.ToString();

        UltimateKills.text = 0.ToString();
        OverallKills.text = 0.ToString();
    }

}