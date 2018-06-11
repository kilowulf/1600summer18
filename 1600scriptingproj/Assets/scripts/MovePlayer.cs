using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovePlayer : MonoBehaviour {

    
    private CharacterController controller;
    private Vector3 newPosition;
    public float Speed =10.0f;
    public float Gravity = 9.01f;
    public float JumpSpeed = 10.0f;


    // function to characterController
    void start()
    {
        controller = GetComponent<CharacterController>;
    }


    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newPosition.y = JumpSpeed;
        }

        newPosition.x = Speed;
        controller.Move(newPosition * Time.deltaTime);
        newPosition.y -= Gravity;
        
    }
}
