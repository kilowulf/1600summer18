using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovePlayer : MonoBehaviour {
    
    
    // lower case for private, upper for public
    private CharacterController controller;
    private Vector3 newPosition;
    public float Speed = 10.0f;
    public float Gravity = 3.2f;
    public float JumpSpeed = 20.0f;
    public bool CanRun = true;
    
    // function to characterController
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        // create a jump function, isGrounded req. object to be grounded
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            newPosition.y = JumpSpeed;
        }

        newPosition.y -= Gravity;
        // movement along x axis
        if (CanRun)
        {
            newPosition.x = Speed * Input.GetAxis("Horizontal");
            newPosition.z = Speed * Input.GetAxis("Vertical");
        }
        // movement along z axis; alternate to horizontal
        
        controller.Move(newPosition * Time.deltaTime);
    }
}
