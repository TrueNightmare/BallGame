using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_startlevelSettings : MonoBehaviour
{
    /*
     * All this script does is set up the level for the beginning of the level
     */

    [Header("Locks")]
    public bool BlueLocked = true;
    public bool RedLocked = true;
    public bool GreenLocked = true;
    public bool YellowLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.RedLocked = RedLocked;
        GameManager.Instance.BlueLocked = BlueLocked;
        GameManager.Instance.GreenLocked = GreenLocked;
        GameManager.Instance.YellowLocked = YellowLocked;
    }
}
