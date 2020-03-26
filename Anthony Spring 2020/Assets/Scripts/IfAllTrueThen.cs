using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class IfAllTrueThen : MonoBehaviour
{
    public UnityEvent TrueEvent;
    public List<BoolData> testBools;

    public void Update()
    {
        foreach (var i in testBools)
        {
            if (i.Value == false)
            {
                return;
            }
        }
        TrueEvent.Invoke();
    }
}
