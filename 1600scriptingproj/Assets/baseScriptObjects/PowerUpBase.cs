﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpBase : ScriptableObject {

    public Animal AnyAnimal;

    //Range sets low to high permitted parameter
    public float PowerLevel = 1.0f;

    //onEnable runs when powerbase is enabled
    public void RunPowerUp ()
    {
        AnyAnimal.Health += PowerLevel;
    }
}
