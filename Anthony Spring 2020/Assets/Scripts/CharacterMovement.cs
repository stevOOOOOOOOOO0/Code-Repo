using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CharacterMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform OldLocation;
    public GameObject ActivateMe;
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void InteractWithMovement()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit == true)
        {
                setLocation(OldLocation, transform);
                setRotationToLookAt(OldLocation, transform);
                StartMoveAction(hit.point);
        }
    }

    public static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    
    public void StartMoveAction(Vector3 destination)
    {
        MoveTo(destination);
    }

    public void MoveTo(Vector3 destination)
    {
        //controller.Move(destination);
        navMeshAgent.Warp(destination);
    }
    
    public void UpdateAnimator()
    {
        Vector3 velocity = navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
    }

    public void setLocation(Transform setee, Transform setTo)
    {
        setee = setTo;
    }

    public void setRotationToLookAt(Transform setee, Transform LookAt)
    {
        setee.LookAt(LookAt);
    }
    
    public void Activate()
    {
        ActivateMe.SetActive(true);
        ActivateMe.transform.position = OldLocation.position;
        ActivateMe.transform.rotation = OldLocation.rotation;
    }

}
