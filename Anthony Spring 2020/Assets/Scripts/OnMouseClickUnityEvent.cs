using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class OnMouseClickUnityEvent : MonoBehaviour
{
    public UnityEvent OnStart, OnUpdate, MouseClick, MouseDown, MouseUp;

    public void Start()
    {
        OnStart.Invoke();
    }
    
    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
            MouseUp.Invoke();
        if(Input.GetMouseButtonDown(0))
            MouseClick.Invoke();
        if(Input.GetMouseButton(0))
            MouseDown.Invoke();
        OnUpdate.Invoke();
    }
}
