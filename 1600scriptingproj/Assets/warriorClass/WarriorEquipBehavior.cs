using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorEquipBehavior : MonoBehaviour {

    public WarriorClassBase Equip;

    private void OnEnable()
    {
        Debug.Log("Equip");
    }
}
