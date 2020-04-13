using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnKeyDown : MonoBehaviour
{

    public FloatData HealthFlasks;
    public UnityEvent KeyDownEvent;
    
    public void Update()
    {
        if (HealthFlasks.Value > 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                KeyDownEvent.Invoke();
            }
        }
    }
}
