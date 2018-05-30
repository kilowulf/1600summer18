using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBase : ScriptableObject {

    [Range(1, 10)] public float Durability;
    [Range(1, 10)] public int ArmorValue;
    [Range(1, 200)] public float Weight;
    [Range(1, 3)] public int Quality;

    private void OnEnable()
    {
        Debug.Log("Equipped!");
    }
}
