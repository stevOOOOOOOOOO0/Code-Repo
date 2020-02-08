﻿using UnityEngine;
using UnityEngine.Events;


public class GameActionHandler : MonoBehaviour
{
    public GameAction Action;
    public UnityEvent Event;

    private void OnEnable()
    {
        Action.Raise += Respond;
    }

    private void Respond()
    {
        Event.Invoke();
    }
}