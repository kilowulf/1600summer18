using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : ScriptableObject {

    public float Weight;
    [Range(1, 3)] public int Quality;
    [Range(1, 20)] public float Damage;
    [Range(1, 1000)] public float Value;
    [Range(1, 100)] public float Durability;

    private void OnEnable()
    {
        Debug.Log("Strike!!");
    }
}
