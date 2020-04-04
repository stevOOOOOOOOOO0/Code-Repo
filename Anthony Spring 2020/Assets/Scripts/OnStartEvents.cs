using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnStartEvents : MonoBehaviour
{

    public UnityEvent OnStartEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        OnStartEvent.Invoke();
    }
}
