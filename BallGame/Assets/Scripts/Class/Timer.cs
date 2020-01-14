using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Frame;
    public int Seconds;
    public int Minutes;
    public bool Active { get; private set; }

    public Timer(bool StartTimer)
    {
        SetActive(StartTimer);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            Frame += Time.deltaTime;

            if (Frame >= 60)
            {
                Frame = 0;
                Seconds++;

                if (Seconds >= 60)
                {
                    Seconds = 0;
                    Minutes++;
                }
            }
        }
    }

    /// <summary>
    /// Switches Timer State
    /// </summary>
    public void SetActive()
    {
        Active = !Active;
    }

    /// <summary>
    /// Sets Timer State
    /// </summary>
    /// <param name="ChangeState"></param>
    public void SetActive(bool ChangeState)
    {
        Active = ChangeState;
    }

    public void ResetClock()
    {
        Frame = 0;
        Seconds = 0;
        Minutes = 0;
    }

    public string CurrentTime()
    {
        string Time = "";

        if (Minutes > 0)
        {
            Time += Minutes + ":";
        }

        if (Seconds > 0 || Minutes > 0)
        {
            Time += Seconds + ":";
        }

        Time += Frame.ToString("F2");

        return Time;
    }

    public float ReturnSeconds()
    {
        return (((float)Minutes * 60) * 60) + ((float)Seconds * 60) + Frame;        
    }
}
