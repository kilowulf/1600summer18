using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()] // function to create a menu: animal assets
public class Animal : ScriptableObject {

    // capitalize public variables, class names
    //public PowerUpBase PowerUp;
    public WeaponBase WeaponDamage;
    
    public float Health = 1.0f;
    public float Speed = 1.0f;
    public float Strength = 1.0f;
    public int LegCount = 2;


    // connect behavior scripts
    //public PowerUpBase PowerUp;
    

    // update health function
    // custom function for adding health
    //public void UpdateHealth()
    //{
    // function operation
    //   Health += PowerUp.PowerLevel;
    //}

    // simulate damage taken
    public void DamageToHealth()
    {   // reduce health by Damage float
        Health -= WeaponDamage.Damage;
    }

    


    
    

}
