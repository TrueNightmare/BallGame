using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

    public void SetGraphic(int Quailtiy)
    {
        UnityEngine.QualitySettings.SetQualityLevel(Quailtiy);
    }
}
