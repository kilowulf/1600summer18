using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBehavior : MonoBehaviour {

    public ArmorBase ArmorBoost;

    private void OnMouseDown()
    {
        Debug.Log(ArmorBoost.ArmorValue);
    }
}
