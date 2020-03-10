using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIdBehaviour : IdBehaviour
{
  
    [Serializable]
    public struct possibleMatch
    {
        public NameId nameIdObj;
        public UnityEvent workEvent, TriggerExitEvent;
    }

    public List<possibleMatch> nameIdList;
    [SerializeField]
    public Dictionary<NameId, UnityEvent> nameIdDictionary;

    private NameId otherIdObj;
    private IdBehaviour otherBehaviourObj;
   
    private void OnTriggerEnter(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if (otherBehaviourObj == null) return;

        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in nameIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workEvent.Invoke();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if (otherBehaviourObj == null) return;

        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckIdExit();
    }

    private void CheckIdExit()
    {
        foreach (var obj in nameIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.TriggerExitEvent.Invoke();
            }
        }
    }
}