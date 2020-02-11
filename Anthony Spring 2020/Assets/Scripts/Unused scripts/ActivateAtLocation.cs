using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAtLocation : MonoBehaviour
{
    public GameObject ActivateMe;
    public Transform Location;

    public void Activate()
    {
        ActivateMe.SetActive(true);
        ActivateMe.transform.position = Location.position;
        ActivateMe.transform.rotation = Location.rotation;
    }
}
