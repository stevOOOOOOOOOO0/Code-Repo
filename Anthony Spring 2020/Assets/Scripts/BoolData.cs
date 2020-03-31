using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool Value;

    public void setValueTrue()
    {
        Value = true;
    }

    public void setValueFalse()
    {
        Value = false;
    }

    public void SwitchValue()
    {
        if (Value)
            Value = false;
        else
            Value = true;
    }
}
