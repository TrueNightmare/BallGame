using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class s_startGame : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public Canvas HUD;

    int CountDown = 4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTimer());
        GameManager.Instance.CanPlayerMove = false;

    }

    private IEnumerator CountDownTimer()
    {
        while (CountDown > -1)
        {
            switch (CountDown)
            {
                case 4:
                    Text.text = "3";
                    break;
                case 3:
                    Text.text = "2";
                    break;
                case 2:
                    Text.text = "1";
                    break;
                case 1:
                    Text.text = "GO!";
                    break;
                case 0:
                    GameManager.Instance.CanPlayerMove = true;
                    HUD.enabled = true;
                    GameManager.Instance.Timer.SetActive(true);
                    Destroy(gameObject);
                    break;
                default:
                    break;
            }
            CountDown--;
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
