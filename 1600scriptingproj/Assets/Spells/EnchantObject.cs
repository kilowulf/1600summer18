using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnchantObject : ScriptableObject
{

    public float DamageLevel = 20;

    public float DoDamage()
    {
        return DamageLevel;
    }
}


