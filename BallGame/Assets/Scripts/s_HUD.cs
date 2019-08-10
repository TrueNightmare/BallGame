using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class s_HUD : MonoBehaviour
{
    public TextMeshProUGUI Time;

    // Update is called once per frame
    void Update()
    {
        Time.text = GameManager.Instance.Timer.CurrentTime();
    }
}
