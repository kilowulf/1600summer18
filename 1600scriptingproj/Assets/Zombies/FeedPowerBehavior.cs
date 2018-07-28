using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedPowerBehavior : MonoBehaviour {

    public FeedPowerBase FeedPowerUp;
    // Use this for initialization
    private void OnTriggerEnter()
    {
        // runs power up method before de-activating
        
        FeedPowerUp.Feed();

        // mono methods to switch off a object; make disappear
        // gameObject self reference to the powerup object
        gameObject.SetActive(false);
    }
}
