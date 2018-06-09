<<<<<<< HEAD:1600scriptingproj/Assets/powerUps/PowerUpBehavior.cs
﻿using System.Collections;
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
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {
    // behavior can apply across classes

    public PowerUpBase PowerUp;

    private void OnTriggerEnter()
    {
        // function call to add health power up
        PowerUp.RunPowerUp();
        // will turn of game object
        gameObject.SetActive(false);
    }


}
>>>>>>> master:1600scriptingproj/Assets/powerups/PowerUpBehavior.cs
