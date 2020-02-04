using System;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseClickUnityEvent : MonoBehaviour
{
    public UnityEvent MouseDown, MouseUp;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseDown.Invoke();
        }

        if (Input.GetMouseButtonUp(0))
        {
            MouseUp.Invoke();
        }
    }

//    public void OnMouseDown()
//    {
//        onMouseClick.Invoke();
//        print("we in it");
//    }
}
