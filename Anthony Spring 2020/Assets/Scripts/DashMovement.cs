using System;
using UnityEngine;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector, newPosition, oldPosition, BaseMovementOldPosition;
    public CharacterController Controller;
    private RaycastHit hit;
    private Vector3 moveDirection;
    public float VerticalChange, HorizontalChange, YValue, MaxMoveDistance;
    private bool Looking;
    public BoolData CanMove;
    
    

    public void BaseMovement()
    {
        if (CanMove.Value)
        {
            if (Controller.isGrounded)
            {
                YValue = -9.8f;
            }
            else
            {
                YValue += -80f * Time.deltaTime;
            }
            
            movementVector.Set(Input.GetAxis("Vertical") * VerticalChange, YValue, Input.GetAxis("Horizontal") * HorizontalChange);
            Controller.Move(movementVector * Time.deltaTime);
            if (Looking == false)
            {
                if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
                {
                    transform.forward = new Vector3(movementVector.x, 0, movementVector.z);
                }
            }
            Looking = false;
        }
    }

    public void CharacterControllerMoveToClick()
    {
        if (CanMove.Value)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Looking = true;
                //set the original position before you start all of these
                //set the range of the movement depending on the distance of the mouse
                if (Vector3.Distance(oldPosition, hit.point) > MaxMoveDistance)
                {
                    moveDirection = Vector3.Lerp(oldPosition, hit.point, MaxMoveDistance / Vector3.Distance(oldPosition, hit.point));
                    moveDirection = moveDirection - transform.position;
                    moveDirection -= Vector3.forward * 1;
                    moveDirection.Set(moveDirection.x, -100f, moveDirection.z);
                }
                else
                {
                    moveDirection = hit.point - transform.position;
                    moveDirection -= Vector3.forward * 1;
                    moveDirection.Set(moveDirection.x, -100f, moveDirection.z);
                }

                Controller.Move(moveDirection);
                moveDirection = transform.position - oldPosition;
                transform.forward = new Vector3(moveDirection.x, 0, moveDirection.z);
            }
        }
    }

    public void SetOldPosition()
    {
        oldPosition = transform.position;
    }

    public void SetGravity(float newGravity)
    {
        YValue = newGravity;
    }
}