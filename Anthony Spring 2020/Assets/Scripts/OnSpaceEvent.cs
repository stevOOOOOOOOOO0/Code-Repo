using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnSpaceEvent : MonoBehaviour
{

    public UnityEvent onSpaceDownEvent;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            onSpaceDownEvent.Invoke();
        }
    }
}
