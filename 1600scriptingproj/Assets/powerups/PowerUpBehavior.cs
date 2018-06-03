using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {
    // behavior can apply across classes

    public PowerUpBase PowerUp;

    private void OnTriggerEnter()
    {
        // will turn of game object
        gameObject.SetActive(false);
    }


}
