using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{

    public UnityEvent OnTriggerEnterEvent, OnTriggerExitEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        OnTriggerExitEvent.Invoke();
    }
}
