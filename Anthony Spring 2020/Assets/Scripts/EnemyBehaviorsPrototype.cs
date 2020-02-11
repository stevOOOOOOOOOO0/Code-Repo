using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBehaviorsPrototype : MonoBehaviour
{

    public UnityEvent OnHit;

    public void InvokeOnHit()
    {
        OnHit.Invoke();
    }
}
