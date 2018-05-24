using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PowerUpBase : ScriptableObject {

    //Range sets low to high permitted parameter
   [Range(0, 10)] public float PowerLevel = 10.0f;

    //onEnable runs when powerbase is enabled
    private void OnEnable()
    {
        Debug.Log("Power Up");
    }
}
