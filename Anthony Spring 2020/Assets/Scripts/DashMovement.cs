using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class DashMovement : MonoBehaviour
{

    private Vector3 movementVector;
    private NavMeshAgent navMeshAgent;
    private RaycastHit hit;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void BaseMovement()
    {
        movementVector.Set(Input.GetAxis("Vertical") * .25f, 0, -Input.GetAxis("Horizontal") * .25f);
        navMeshAgent.Move(movementVector);
    }

    public void NavMeshWarpToClick()
    {
        bool hasHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
        if (hasHit)
        {
            navMeshAgent.Warp(hit.point);
        }
    }
}