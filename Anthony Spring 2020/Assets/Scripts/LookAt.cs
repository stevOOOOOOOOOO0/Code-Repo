using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    public Transform LookAtMe;

    private Quaternion DesiredRotation;
    public float Smoothness;
    public bool Looking = true;

    void Update()
    {
        if (Looking)
        {
            DesiredRotation = Quaternion.LookRotation(LookAtMe.position - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, DesiredRotation, Smoothness);
        }
    }

    public void Startlooking()
    {
        Looking = true;
    }

    public void StopLooking()
    {
        Looking = false;
    }
}