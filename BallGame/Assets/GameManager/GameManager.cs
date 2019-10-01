using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameProgress gp;

    //string SaveDirectory = Application.dataPath + "/Save.txt";

    void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }


    [Header("Locks")]

    public bool BlueLocked;
    public bool RedLocked;
    public bool GreenLocked;
    public bool YellowLocked;

    [Header("Player Controls")]
    public bool CanPlayerMove = false;

    [Header("Player Stats")]
    public int GoldMedals;
    public int SliverMedals;
    public int Bronze;

    [Header("Background Level")]
    public float Seconds;

    [Header("Level Timer")]
    public GameObject TimerGameObject;
    public s_Timer Timer;
    public float goldTime;
    public float sliverTime;
    public float bronzeTime;

    [Header("Game Overall Settings")]
    public List<s_LevelTimes> LevelTimes = new List<s_LevelTimes>();

    // Start is called before the first frame update
    void Start()
    {
        TimerGameObject = new GameObject();
        TimerGameObject.AddComponent<s_Timer>();
        Timer = TimerGameObject.GetComponent<s_Timer>();
        Timer.SetActive(false);
        Timer.ResetClock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLockedState(int ColourIndex)
    {
        switch (ColourIndex)
        {
            case 0:
                RedLocked = !RedLocked;
                break;
            case 1:
                BlueLocked = !BlueLocked;
                break;
            case 2:
                GreenLocked = !GreenLocked;
                break;
            case 3:
                YellowLocked = !YellowLocked;
                break;
            default:
                break;
        }
    }

    public class GameProgress
    {
        public float[] times;
        public bool World2Unlocked;
        public bool World3Unlocked;
        public bool World4Unlocked;
    }

    //Doesn't save, still need to do that
    public void SaveGame()
    {
        string File = JsonUtility.ToJson(gp);       //Converts game object to string, for saving.
        //System.IO.File.
    }

    //Doesn't collect file, still need that
    //public void LoadGame()
    //{
    //    if (System.IO.File.Exists(SaveDirectory))
    //    {
    //        gp = JsonUtility.FromJson<GameProgress>(SaveDirectory);
    //        //System.IO.File.OpenRead(SaveDirectory);
    //    }
    //    else
    //    {
    //        Debug.Log("Game Save not found, Created new at: " + SaveDirectory);
    //        gp = new GameProgress
    //        {
    //            times = new float[20],
    //            World2Unlocked = false,
    //            World3Unlocked = false,
    //            World4Unlocked = false
    //        };
    //        SaveGame();
    //    }
    //}
}
