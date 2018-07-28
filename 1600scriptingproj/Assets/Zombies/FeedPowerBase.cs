using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class FeedPowerBase : ScriptableObject {


    public Zombie AnyZombie;
    public float FeedPowerUp = 10.0f;
    // Use this for initialization
    public void Feed()
    {
        AnyZombie.Health += FeedPowerUp;
    }

    private void OnEnable()
    {
        Debug.Log("Feed!");
    }
}
