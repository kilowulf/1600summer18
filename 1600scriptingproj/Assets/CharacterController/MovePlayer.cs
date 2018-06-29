using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovePlayer : MonoBehaviour {
    
    
    // lower case for private, upper for public
    
    // object of controller class 
    private CharacterController controller;
    // vector3 datatype to represent positions
    private Vector3 newPosition;
    
    public float Speed = 10.0f;
    public float Gravity = 3.2f;
    public float JumpSpeed = 20.0f;
    public bool CanRun = true;
    
    // Start 
    void Start()
    {
        // on start controller will use method to load controller
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
            // movement along x, y axis                   
            newPosition.x = Speed * Input.GetAxis("Horizontal");
            newPosition.z = Speed * Input.GetAxis("Vertical");
        }
        
        // time.delta sets movement at regular intervals
        controller.Move(newPosition * Time.deltaTime);
    }
}
