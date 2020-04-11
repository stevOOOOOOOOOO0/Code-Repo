using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBehaviorsPrototype : MonoBehaviour
{

    public UnityEvent SwordOnHit, ShieldOnHit, StunnedSwordOnHit;
    public int health;
    public BoolData usingSword;
    private bool Stunned = false;

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
            {
                if (Stunned)
                {
                    StunnedSwordOnHit.Invoke();
                }
                else
                {
                    SwordOnHit.Invoke();
                }
            }
        }

        if (usingSword.Value == false)
        {
            ShieldOnHit.Invoke();
        }
    }

    public void AddHealth()
    {
        health += 1;
    }

    public void Stun()
    {
        Stunned = true;
    }

    public void Unstun()
    {
        Stunned = false;
    }
}
