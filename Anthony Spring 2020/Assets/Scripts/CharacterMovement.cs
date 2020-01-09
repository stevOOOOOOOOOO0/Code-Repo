using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Requirecomponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

    private Vector3 position;
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
        
        
    }
}
