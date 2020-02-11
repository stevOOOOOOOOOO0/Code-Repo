using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Cinemachine;
using UnityEngine;

public class DisableAttributes : MonoBehaviour
{
    public CinemachineVirtualCamera CVC;
    public float Timer;
    public Transform player;
    public bool Subtract;

    public void addToTimer()
    {
        Timer += 1;
    }

    public void StartCoroutine()
    {
        StartCoroutine(WaitThreeSeconds());
    }

    public IEnumerator WaitThreeSeconds()
    {
        CVC.Follow = null;
        CVC.LookAt = null;
        
        while (Timer > 0)
        {
            if (Subtract)
                Timer -= 1 * Time.deltaTime;
        }

        CVC.Follow = player;
        CVC.LookAt = player;
        yield return new WaitForSeconds(0f);
    }

    public void SubtractTrue()
    {
        Subtract = true;
    }

    public void SubtractFalse()
    {
        Subtract = false;
    }

}
