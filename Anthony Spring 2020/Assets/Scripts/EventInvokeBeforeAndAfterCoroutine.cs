using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInvokeBeforeAndAfterCoroutine : MonoBehaviour
{

    public UnityEvent BeforeEvent, AfterEvent;
    
    public void StartCoroutine(float time)
    {
        StartCoroutine(EventCoroutine(time));
    }

    public IEnumerator EventCoroutine(float time)
    {
        BeforeEvent.Invoke();
        yield return new WaitForSeconds(time);
        AfterEvent.Invoke();
    }
}
