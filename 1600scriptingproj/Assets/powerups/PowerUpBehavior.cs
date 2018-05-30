using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {
    // behavior can apply across classes

    public PowerUpBase PowerUp;

    //mouse down event yields PowerUp
    private void OnMouseDown()
    {
        Debug.Log("PowerUp.PowerLevel");
    }
}
