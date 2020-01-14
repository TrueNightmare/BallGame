using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelTimes
{
    //Level Details
    public float GoldTime;
    public float SliverTime;
    public float BronzeTime;

    //Player Details
    public float BestTime;

    //Creation
    public LevelTimes( float goldTime, float sliverTime, float bronzeTime)
    {
        GoldTime = goldTime;
        SliverTime = sliverTime;
        BronzeTime = bronzeTime;
        BestTime = 9999999;
    }

    //Loading
    public LevelTimes(string levelNumber, float goldTime, float sliverTime, float bronzeTime, float bestTime)
    {
        GoldTime = goldTime;
        SliverTime = sliverTime;
        BronzeTime = bronzeTime;
        BestTime = bestTime;
    }
}