using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material InitialMaterial, NewMaterial;

    public void SwapToNewMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = NewMaterial;
    }
    
    public void SwapToInitialMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = InitialMaterial;
    }
}
