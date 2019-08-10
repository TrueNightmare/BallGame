using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Timer : MonoBehaviour
{
    public float Seconds;
    public int Minutes;
    public int Hours;
    public bool Active { get; private set; }

    public s_Timer(bool StartTimer)
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
            Seconds += Time.deltaTime;

            if (Seconds >= 60)
            {
                Seconds = 0;
                Minutes++;

                if (Minutes >= 60)
                {
                    Minutes = 0;
                    Hours++;
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
        Seconds = 0;
        Minutes = 0;
        Hours = 0;
    }

    public string CurrentTime()
    {
        string Time = "";

        if (Hours > 0)
        {
            Time += Hours + ":";
        }

        if (Minutes > 0 || Hours > 0)
        {
            Time += Minutes + ";";
        }

        Time += Seconds.ToString("F2");

        return Time;
    }

    public float ReturnSeconds()
    {
        return (((float)Hours * 60) * 60) + ((float)Minutes * 60) + Seconds;        
    }
}
