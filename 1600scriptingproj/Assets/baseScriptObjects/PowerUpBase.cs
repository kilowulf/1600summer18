
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpBase : ScriptableObject {


    // ref to Animal class
    public Animal AnyAnimal;

    //Range sets low to high permitted parameter
   [Range(0, 10)] public float PowerLevel = 10.0f;

    public void RunPowerUp()
    {
        // any animal can be updated
        AnyAnimal.Health += PowerLevel;
    }

    //onEnable runs when powerbase is enabled
    private void OnEnable()
    {
        Debug.Log("Power Up");
    }
}
