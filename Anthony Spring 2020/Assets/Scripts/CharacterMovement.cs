using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CharacterMovement : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    private CharacterController controller;
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        //UpdateAnimator();
        InteractWithMovement();
    }
    
    private bool InteractWithMovement()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit == true)
        {
            if (Input.GetMouseButton(0))
            {
                StartMoveAction(hit.point);
            }
            return true;
        }
        return false;
    }

    private static Ray GetMouseRay()
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
    
    private void UpdateAnimator()
    {
        Vector3 velocity = navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
    }
    
    /*private Vector3 position;
    private Charactercontroller controller;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCount Max = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0f;
            jumpCount++;
        }

        controller.Move(position * time.deltatime);
        
        
    }*/
}
