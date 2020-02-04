using System;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseClickUnityEvent : MonoBehaviour
{
    public UnityEvent MouseDown, OnStart, OnUpdate;

    public void Start()
    {
        OnStart.Invoke();
    }
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseDown.Invoke();
        }
        OnUpdate.Invoke();
    }
}
