using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckForZeroFloatData : MonoBehaviour
{
    public FloatData fData;
    public UnityEvent ZeroEvent;

    // Update is called once per frame
    void Update()
    {
        if (fData.Value <= 0)
        {
            ZeroEvent.Invoke();
            ZeroEvent.RemoveAllListeners();
        }
    }
}
