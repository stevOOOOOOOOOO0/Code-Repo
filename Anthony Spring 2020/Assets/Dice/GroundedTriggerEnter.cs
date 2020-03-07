using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundedTriggerEnter : MonoBehaviour
{

    public UnityEvent TriggerEvent;
    public CharacterController ParentCC;

    public void OnTriggerEnter()
    {
        if (ParentCC.isGrounded)
        {
            TriggerEvent.Invoke();
            Debug.Log("triggered");
        }
    }
}
