using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CharacterControllerKnockBack : MonoBehaviour
{
    public Transform transformForRelation;
    private Vector3 finalPosition, offset, movement;
    public float offsetAmount, speed, time;
    public bool canMove;
    public CharacterController Controller;
    public UnityEvent timerEvent;

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
        {
            movement = transform.TransformDirection(Vector3.back) * speed * Time.deltaTime;
            Controller.Move(movement);
            StartCoroutine(timer());
        }
            
    }

    public void SetOffsetValue(float value)
    {
        offsetAmount = value;
    }

    public IEnumerator timer()
    {
        yield return new WaitForSeconds(time);
        canMove = false;
        timerEvent.Invoke();
    }
}