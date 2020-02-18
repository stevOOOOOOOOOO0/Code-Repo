using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{

    public UnityEvent OnTriggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
    }
}
