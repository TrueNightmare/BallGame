using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_startlevelSettings : MonoBehaviour
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
    public float goldTime;
    public float sliverTime;
    public float bronzeTime;

    // Start is called before the first frame update
    void Awake()
    {
        GameManager.Instance.RedLocked = RedLocked;
        GameManager.Instance.BlueLocked = BlueLocked;
        GameManager.Instance.GreenLocked = GreenLocked;
        GameManager.Instance.YellowLocked = YellowLocked;

        GameManager.Instance.goldTime = goldTime;
        GameManager.Instance.sliverTime = sliverTime;
        GameManager.Instance.bronzeTime = bronzeTime;

        GameManager.Instance.CanPlayerMove = CanPlayerMove;
    }
}
