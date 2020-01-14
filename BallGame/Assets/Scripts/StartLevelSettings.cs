using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelSettings : MonoBehaviour
{
    /*
     * All this script does is set up the level for the beginning of the level
     */

    [Header("Locks")]

    public bool BlueLocked;
    public bool RedLocked;
    public bool GreenLocked;
    public bool YellowLocked;

    [Header("Player Controls")]
    public bool CanPlayerMove = false;

    [Header("Medal Times")]
    public float GoldTime;
    public float SliverTime;
    public float BronzeTime;

    // Start is called before the first frame update
    void Awake()
    {
        GameManager.Instance.RedLocked = RedLocked;
        GameManager.Instance.BlueLocked = BlueLocked;
        GameManager.Instance.GreenLocked = GreenLocked;
        GameManager.Instance.YellowLocked = YellowLocked;

        GameManager.Instance.goldTime = GoldTime;
        GameManager.Instance.sliverTime = SliverTime;
        GameManager.Instance.bronzeTime = BronzeTime;

        GameManager.Instance.CanPlayerMove = CanPlayerMove;
    }
}
