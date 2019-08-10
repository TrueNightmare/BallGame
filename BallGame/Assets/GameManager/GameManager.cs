using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

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

    [Header("Background Level")]
    public float Seconds;

    [Header("Level Timer")]
    public GameObject TimerGameObject;
    public s_Timer Timer;
    public float goldTime;
    public float sliverTime;
    public float bronzeTime;

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
}
