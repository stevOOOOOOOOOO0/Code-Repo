﻿using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector, newPosition;
    public CharacterController Controller;
    private RaycastHit hit;
    public AfterImagesSOPrototype AfterImageSO;
    private Vector3 moveDirection;

    public void BaseMovement()
    {
        AfterImageSO.Location = transform;
        movementVector.Set(Input.GetAxis("Vertical") * .25f, 0, -Input.GetAxis("Horizontal") * .25f);
        Controller.Move(movementVector);
    }

    public void CharacterControllerMoveToClick()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            moveDirection = hit.point - transform.position;
            moveDirection -= Vector3.forward * 1;
            Controller.Move(moveDirection);
        }
    }
    
    
}