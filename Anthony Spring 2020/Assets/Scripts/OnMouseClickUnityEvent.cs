using System;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseClickUnityEvent : MonoBehaviour
{
    public UnityEvent onMouseClick;

    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            onMouseClick.Invoke();
        }
    }

//    public void OnMouseDown()
//    {
//        onMouseClick.Invoke();
//        print("we in it");
//    }
}
