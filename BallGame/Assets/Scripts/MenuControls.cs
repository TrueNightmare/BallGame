using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
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
    }

    public void MainToSettings(GameObject NextSelected)
    {

    }
}
