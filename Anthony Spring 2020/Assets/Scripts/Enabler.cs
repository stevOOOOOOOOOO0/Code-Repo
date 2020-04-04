using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    
    public GameObject obj;
    
    
    public void Enable()
    {
        obj.SetActive(true);
    }

    public void Disable()
    {
        obj.SetActive(false);
    }

    public void Swap()
    {
        if (obj.active)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}
