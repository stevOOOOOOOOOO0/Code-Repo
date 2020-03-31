using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBehaviorsPrototype : MonoBehaviour
{

    public UnityEvent SwordOnHit, ShieldOnHit;
    public int health;
    public BoolData usingSword;

    public void InvokeOnHit()
    {
        SubtractHealth();
    }

    public void SubtractHealth()
    {
        health -= 1;
        if (health <= 0)
        {
            if (usingSword.Value)
                SwordOnHit.Invoke();
        }
        if (usingSword.Value == false)
            ShieldOnHit.Invoke();
    }

    public void AddHealth()
    {
        health += 1;
    }
}
