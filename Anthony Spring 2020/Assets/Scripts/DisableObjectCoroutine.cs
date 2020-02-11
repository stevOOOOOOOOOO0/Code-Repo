using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjectCoroutine : MonoBehaviour
{

    public void StartCoroutine()
    {
        StartCoroutine(DisableCoroutine());
    }
    
    public IEnumerator DisableCoroutine()
    {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
    }
}
