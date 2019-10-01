using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class s_LevelTimes
{
    //Level Details
    public float GoldTime;
    public float SliverTime;
    public float BronzeTime;

    //Player Details
    public float BestTime;

    //Creation
    public s_LevelTimes( float goldTime, float sliverTime, float bronzeTime)
    {
        GoldTime = goldTime;
        SliverTime = sliverTime;
        BronzeTime = bronzeTime;
        BestTime = 9999999;
    }

    //Loading
    public s_LevelTimes(string levelNumber, float goldTime, float sliverTime, float bronzeTime, float bestTime)
    {
        GoldTime = goldTime;
        SliverTime = sliverTime;
        BronzeTime = bronzeTime;
        BestTime = bestTime;
    }
}