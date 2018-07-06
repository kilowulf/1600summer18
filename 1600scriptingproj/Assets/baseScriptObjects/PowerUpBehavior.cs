
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {
    
    public PowerUpBase PowerUp;

    private void OnTriggerEnter()
    {
        // runs power up method before de-activating
        PowerUp.RunPowerUp();

        // mono methods to switch off a object; make disappear
        // gameObject self reference to the powerup object
        gameObject.SetActive(false);
    }
}
