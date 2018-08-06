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
    public float MoveSpeed = 15.0f;
    public float TurnSpeed = 50.0f;
    public float Gravity = 3.2f;
    public float JumpSpeed = 20.0f;
    
    
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
        // movement along x, y axis                   
        newPosition.x = Speed * Input.GetAxis("Horizontal");
        newPosition.z = Speed * Input.GetAxis("Vertical");       
        
        // time.delta sets movement at regular intervals to deal with FPS variability
        controller.Move(newPosition * Time.deltaTime);

        // Transform and rotate script for player with arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }
}

