using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    private CharacterController character;
    private Vector3 moveVector;
    public float moveSpeed = 5;
    public float rotateSpeed = 2;

    private void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Rotate(float _myInput)
    {
        transform.Rotate(0, _myInput * rotateSpeed, 0);
    }

    void Move(float _myInput)
    {
        moveVector.x = _myInput;
        moveVector = transform.TransformDirection(moveVector * moveSpeed * Time.deltaTime);
        character.Move(moveVector);
    }

    void Update()
    {
        Move(Input.GetAxis("Vertical"));
        Rotate(Input.GetAxis("Horizontal"));
    }



}
