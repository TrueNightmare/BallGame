using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class MenuControls : MonoBehaviour
{
    [Header("Event Handler")]
    public EventSystem EventSystem;

    [Header("Canvas")]
    public Canvas Main;
    public Canvas Settings;
    public Canvas World;

    [Header("First Buttons")]
    public GameObject MainButton;
    public GameObject SettingsButton;
    public GameObject WorldButton;

    [Header("Audio Mixers")]
    int GameQauitly;
    float MasterAudio;
    float MusicAudio;
    float FXAudio;

    [Header("Level Select Counter")]
    public int LevelCount;

    [Header("Level Select Tags")]
    public TextMeshProUGUI levelName;
    public TextMeshProUGUI bestTime;
    public GameObject medalBest;
    public TextMeshProUGUI goldTime;
    public TextMeshProUGUI silverTime;
    public TextMeshProUGUI bronzeTime;
    public bool isUnlocked;

    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Button Pressed");
    }

    public void MainToSettings()
    {
        Main.enabled = false;
        Settings.enabled = true;
        EventSystem.firstSelectedGameObject = SettingsButton;
    }

    public void SettingsToMain()
    {
        Settings.enabled = false;
        Main.enabled = true;
        EventSystem.firstSelectedGameObject = MainButton;
    }

    public void MainToWorld()
    {
        Main.enabled = false;
        World.enabled = true;
        EventSystem.firstSelectedGameObject = WorldButton;
    }

    public void WorldToMain()
    {
        World.enabled = false;
        Main.enabled = true;
        EventSystem.firstSelectedGameObject = MainButton;
    }

    public void SetGraphic(int Quailtiy)
    {
        GameQauitly = Quailtiy;
    }

    public void ApplySettings()
    {
        UnityEngine.QualitySettings.SetQualityLevel(GameQauitly);
        //Audio still needs to be worked on

        SettingsToMain();
    }

    public void RequestLevelInformation()
    {

    }
}
