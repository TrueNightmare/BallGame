using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdjuster : MonoBehaviour
{
    public GameObject Player;

    //Player Information
    Vector3 PlayerStartingLocation;
    Vector3 CurrentPlayerLocation;
    Vector3 Difference;

    Vector3 LevelPos;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStartingLocation = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentPlayerLocation = Player.transform.position;
        Difference = PlayerStartingLocation - CurrentPlayerLocation;
        LevelPos = transform.position;

        transform.position = LevelPos + Difference;
        
    }
}
