using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class CharacterControllerMovements : MonoBehaviour
{
    
    public CharacterController Controller;
    public Rigidbody rotator;
    public Vector3 Movement, Rotation;

    public void Update()
    {
        if (Movement.y > -9.8f)
            Movement += (Vector3.down * (9.8f * Time.deltaTime));
        Controller.Move(Movement * Time.deltaTime);
        rotator.AddTorque(Rotation);
    }

    public void Jump()
    {
        Movement.Set(0,10,0);
    }

    public void AddRoll()
    {
        Rotation.Set(Random.Range(0,10), Random.Range(0,10), Random.Range(0,10));
    }
}
