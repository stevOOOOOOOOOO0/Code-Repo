using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBehaviorsPrototype : MonoBehaviour
{

    public UnityEvent OnHit;
    public int health;

    public void InvokeOnHit()
    {
        SubtractHealth();
        Debug.Log("in it");
    }

    public void SubtractHealth()
    {
        health -= 1;
        if (health == 0)
        {
            OnHit.Invoke();
        }
    }
}
