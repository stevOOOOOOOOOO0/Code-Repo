using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClickLocation : MonoBehaviour
{
    
    private RaycastHit hit;
    public Vector3Data ClickLocation;
    
    public void LocationOfClick() 
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            ClickLocation.Value = hit.point;
        }
    }
}