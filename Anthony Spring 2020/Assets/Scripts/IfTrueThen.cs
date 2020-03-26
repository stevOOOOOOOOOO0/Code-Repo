using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IfTrueThen : MonoBehaviour
{

    [Serializable]
    public struct possibleMatch
    {
        public BoolData boolDataObj;
        public UnityEvent TrueEvent;
    }

    public List<possibleMatch> ifThisThen;

    public void Update()
    {
        foreach (var i in ifThisThen)
        {
            if (i.boolDataObj.Value)
            {
                i.TrueEvent.Invoke();
            }
        }
    }
}