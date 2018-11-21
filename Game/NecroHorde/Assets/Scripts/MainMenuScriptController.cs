using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuScriptController : MonoBehaviour {

    [SerializeField] GameObject Main;
    [SerializeField] Button MainMenuDefaultButton;
    [SerializeField] GameObject ClassSelect;
    [SerializeField] Button ClassSelectDefaultButton;
    [SerializeField] GameObject HighScore;
    [SerializeField] Button HighScoreDefaultButton;
    [SerializeField] GameObject Options;
    [SerializeField] Button OptionsDeaultButton;
    [SerializeField] Scene PlayScene;
    [SerializeField] Slider SensitivityXSlider;
    [SerializeField] Slider SensitivityYSlider;
    [SerializeField] Text SensitivityXText;
    [SerializeField] Text SensitivityYText;
    [SerializeField] Button ClassPlayButton;
    [SerializeField] GameObject UnlockPanel;
    [SerializeField] AudioSource MusicPlayer;
    [SerializeField] Slider MusicVolumeSlider;
    [SerializeField] Text MusicVolumeText;

    ClassController ClassC;


    private void Start()
    {
        OpenMainMenu();
        MainMenuDefaultButton.Select();
        MusicPlayer = FindObjectOfType<AudioSource>();
        ClassC = FindObjectOfType<ClassController>();
        SetOptions();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Exit Menu"))
        {
            OpenMainMenu();
        }
    }

    void SetOptions()
    {
        UnityStandardAssets.Characters.FirstPerson.MouseLook.XSensitivity = PlayerPrefs.GetFloat("SensitivityX") / 100;
        UnityStandardAssets.Characters.FirstPerson.MouseLook.YSensitivity = PlayerPrefs.GetFloat("SensitivityY") / 100;
        MusicPlayer.volume = PlayerPrefs.GetFloat("MusicVolume") / 100;

        SensitivityXSlider.value = UnityStandardAssets.Characters.FirstPerson.MouseLook.XSensitivity * 100;
        SensitivityYSlider.value = UnityStandardAssets.Characters.FirstPerson.MouseLook.YSensitivity * 100;
        MusicVolumeSlider.value = MusicPlayer.volume * 100;

        SensitivityXText.text = SensitivityXSlider.value.ToString();
        SensitivityYText.text = SensitivityYSlider.value.ToString();
        MusicVolumeText.text = MusicVolumeSlider.value.ToString();
    }

    public void OpenClassMenu()
    {
        Main.SetActive(false);
        ClassSelect.SetActive(true);
        Options.SetActive(false);
        HighScore.SetActive(false);

        ClassSelectDefaultButton.Select();
    }

    public void OpenHighScores()
    {
        Main.SetActive(false);
        ClassSelect.SetActive(false);
        Options.SetActive(false);
        HighScore.SetActive(true);

        HighScoreDefaultButton.Select();
    }

    public void OpenMainMenu()
    {
        Main.SetActive(true);
        ClassSelect.SetActive(false);
        Options.SetActive(false);
        HighScore.SetActive(false);
        UnlockPanel.SetActive(false);

        MainMenuDefaultButton.Select();
    }

    public void OpenOptionsMenu()
    {
        Main.SetActive(false);
        ClassSelect.SetActive(false);
        Options.SetActive(true);
        HighScore.SetActive(false);

        OptionsDeaultButton.Select();
    }

    public void OpenUnlockMenu()
    {
        if(UnlockPanel.activeSelf)
        {
            UnlockPanel.SetActive(false);
        }
        else
        {
            UnlockPanel.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectFireClass()
    {
        ClassC.ChosenClass = "Fire";
    }

    public void SelectLightningClass()
    {
        ClassC.ChosenClass = "Lightning";
    }

    public void SelectEarthClass()
    {
        ClassC.ChosenClass = "Earth";
    }

    public void EnablePlayButton()
    {
        ClassPlayButton.interactable = true;
    }

    public void UpdateSensitivity()
    {
        UnityStandardAssets.Characters.FirstPerson.MouseLook.XSensitivity = SensitivityXSlider.value / 100;
        UnityStandardAssets.Characters.FirstPerson.MouseLook.YSensitivity = SensitivityYSlider.value / 100;

        SensitivityXText.text = SensitivityXSlider.value.ToString();
        SensitivityYText.text = SensitivityYSlider.value.ToString();

        PlayerPrefs.SetFloat("SensitivityX", SensitivityXSlider.value);
        PlayerPrefs.SetFloat("SensitivityY", SensitivityYSlider.value);
    }

    public void UdpateMusicVolume()
    {
        PlayerPrefs.SetFloat("MusicVolume", MusicVolumeSlider.value);

        MusicVolumeText.text = MusicVolumeSlider.value.ToString();  

        MusicPlayer.volume = PlayerPrefs.GetFloat("MusicVolume") / 100;
    }
}