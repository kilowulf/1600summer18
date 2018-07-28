using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Zombie : ScriptableObject {

    public WeaponBase Bite;    
    public FeedPowerBase FeedPowerUp;

    public float Health = 1.0f;
    public float Speed = 1.0f;
    public float Strength = 1.0f;
    

    public void DamageToHealth()
    {   // reduce health by Damage float
        Health -= Bite.Damage;
    }

    public void UpdateHealth()
    {
        Health += FeedPowerUp.FeedPowerUp;
    }

}
