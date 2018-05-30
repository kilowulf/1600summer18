using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponBehavior : MonoBehaviour {

    public WeaponBase WeaponBoost;

    private void OnMouseDown()
    {
        Debug.Log(WeaponBoost.Damage);
    }
}
