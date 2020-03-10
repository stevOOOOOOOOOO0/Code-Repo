using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value;

    public void SetValue(float number)
    {
        Value = number;
    }

    public void AddBy(float number)
    {
        Value += number;
    }

    public void SubtractBy(float number)
    {
        Value -= number;
    }
}
