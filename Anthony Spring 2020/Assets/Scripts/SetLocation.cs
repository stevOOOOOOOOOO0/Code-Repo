using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLocation : MonoBehaviour
{
    public Vector3Data newLocation;

    public void SetTheLocation()
    {
        transform.position.Set(0,0,0);
        transform.position.Set(newLocation.Value.x, newLocation.Value.y, newLocation.Value.z);
    }
}
