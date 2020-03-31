using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravityOnly : MonoBehaviour
{
    private Vector3 movementVector;
    public CharacterController Controller;

    
    public void Start()
    {
        movementVector.Set(0,0,0);
    }

    void Update()
    {

        if (Controller.isGrounded)
            movementVector.y = -1;
        else
            movementVector.y -= (9.8f * Time.deltaTime);
        
        Controller.Move(movementVector);
    }
}
