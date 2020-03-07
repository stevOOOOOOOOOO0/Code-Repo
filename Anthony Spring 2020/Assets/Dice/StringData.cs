using System;
using UnityEngine;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public String Value;

    public void EditString(string edit)
    {
        Value = edit;
    }
}