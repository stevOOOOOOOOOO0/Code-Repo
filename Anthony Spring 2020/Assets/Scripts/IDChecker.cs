using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{
    public NameID nameIDObj;

    private void OnTriggerEnter(Collider other)
    {
        var nameIdObj = other.GetComponent<MatchID>().nameIDObj;
        if (nameIdObj == null) return;
        var otherNameId = nameIdObj;
        if (nameIDObj == otherNameId)
        {
            //do work
        }
    }
}