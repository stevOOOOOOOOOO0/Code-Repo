using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDChecker : ScriptableObject
{
    
    public string NameID;
    public List NameIDs;

    public void OnTriggerEnter(Collider other)
    {
        NameIDs += other.name;
    }

    public void OnTriggerExit(Collider other)
    {
        NameIDs -= other.name;
    }
}