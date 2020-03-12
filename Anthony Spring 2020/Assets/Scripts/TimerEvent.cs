using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{
    public float SetTime;
    private float Time;
    public UnityEvent ZeroEvent;


    public void Start()
    {
        Time = SetTime;
    }

    // Update is called once per frame
    void Update()
    {
        Time -= 1 * UnityEngine.Time.deltaTime;
        if (Time < 0)
        {
            ZeroEvent.Invoke();
            Time = SetTime;
        }
    }

    public void SetTimer(float newTime)
    {
        SetTime = newTime;
        Time = SetTime;
    }
}
