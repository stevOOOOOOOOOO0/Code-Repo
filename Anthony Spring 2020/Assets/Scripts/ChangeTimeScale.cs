using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimeScale : MonoBehaviour
{
    public void SlowTime()
    {
        Time.timeScale = .1f;
    }

    public void NormalizeTime()
    {
        Time.timeScale = 1f;
    }
}
