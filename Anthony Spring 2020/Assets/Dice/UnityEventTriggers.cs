using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTriggers : MonoBehaviour
{

    public UnityEvent OnMouseDownUE;

    public void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            OnMouseDownUE.Invoke();
        }
    }
}
