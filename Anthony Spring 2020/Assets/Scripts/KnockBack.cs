using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public Transform transformForRelation;
    private Vector3 finalPosition, offset;
    public float offsetAmount, speed;
    public bool canMove;

    public void FindFinalPosition()
    {
        finalPosition = transformForRelation.position;
        offset = transformForRelation.forward;
        offset *= offsetAmount;
        finalPosition += offset;
    }

    public void Move()
    {
        canMove = true;
    }
    
    public void Update()
    {
        if (canMove)
            transform.position = Vector3.Lerp(transform.position, finalPosition, speed);

        if (Vector3.Distance(transform.position, finalPosition) < .1f)
            canMove = false;
    }

    public void SetOffsetValue(float value)
    {
        offsetAmount = value;
    }
}
