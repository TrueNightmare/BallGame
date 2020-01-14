using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI LevelName;
    public TextMeshProUGUI TimeTaken;
    public TextMeshProUGUI GoldTime;
    public TextMeshProUGUI SliverTime;
    public TextMeshProUGUI BronzeTime;

    public void UpdateScore()
    {
        LevelName.text = "" + SceneManager.GetActiveScene().name + " Completed";
        TimeTaken.text = GameManager.Instance.Timer.CurrentTime();
        GoldTime.text = GameManager.Instance.goldTime.ToString();
        SliverTime.text = GameManager.Instance.sliverTime.ToString();
        BronzeTime.text = GameManager.Instance.bronzeTime.ToString();
    }
}
