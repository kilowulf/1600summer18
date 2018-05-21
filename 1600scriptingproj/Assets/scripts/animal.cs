using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()] // function to create a menu: animal assets
public class Animal : ScriptableObject {

    public float Health = 1.00f;
    public float Speed = 1.0f;
    public float Strength = 1.0f;

    public int LegCount = 2;


}
