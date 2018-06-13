using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovePlayer : MonoBehaviour {
    
    
    // lower case for private, upper for public
    private CharacterController controller;
    private Vector3 newPosition;
    public float Speed = 10.0f;
    public float Gravity = 9.81f;
    public float JumpSpeed = 10.0f;


    // function to characterController
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        // create a jump function
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newPosition.y = JumpSpeed;
        }

        newPosition.y -= Gravity;
        newPosition.x = Speed*Input.GetAxis("Horizontal");
        controller.Move(newPosition * Time.deltaTime);
    }
}
