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

    public void StartColorDoubleSwapCoroutine(float time)
    {
        StartCoroutine(ColorDoubleSwapCoroutine(time));
    }

    public IEnumerator ColorDoubleSwapCoroutine(float time)
    {
        SwapToNewMaterial();
        yield return new WaitForSeconds(time);
        SwapToInitialMaterial();
    }
}
