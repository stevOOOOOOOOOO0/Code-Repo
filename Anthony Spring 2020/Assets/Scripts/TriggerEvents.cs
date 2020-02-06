using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent OnTriggerEnterCollision;

    public void OnTriggerEnter()
    {
        OnTriggerEnterCollision.Invoke();
    }
}
