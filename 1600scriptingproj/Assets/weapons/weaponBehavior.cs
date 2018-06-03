using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour {

    public WeaponBase WeaponBoost;

    private void OnMouseDown()
    {
        Debug.Log(WeaponBoost.Damage);
    }
}
