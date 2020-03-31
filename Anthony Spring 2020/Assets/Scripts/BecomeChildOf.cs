using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeChildOf : MonoBehaviour
{
    public GameObject newParent;
    private GameObject oldParent;

    public void Start()
    {
        oldParent = transform.parent.gameObject;
    }

    public void NewParent()
    {
        transform.parent = newParent.transform;
    }

    public void OldParent()
    {
        transform.parent = oldParent.transform;
    }
}
