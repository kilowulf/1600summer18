using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu()]
public class FloatData : ScriptableObject
{

    [Range(0, 1)] public float Value;
    public float HealthLevel = 1.0f;
    public float FillAmount = 1.0f;

}
