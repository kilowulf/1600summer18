using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class Weapons : MonoBehaviour {

    // create a drop down list; can change behavior on a object
	public enum WeaponType
	{
		Axe, 
		Club,
		Sword,
		Spear,
		Scimitar,
	}
    // array for weaponObjects
	public WeaponObject[] WeaponObjects;

	public WeaponType CurrentWeapon;

	 void Update()
	{   // set behaviors for each case weapon
		switch (CurrentWeapon)
		{
			case WeaponType.Axe:
				// consoles weapon name
				Debug.Log(WeaponObjects[0].name);
				// consoles damage level
				Debug.Log(WeaponObjects[0].DoDamage());
				break;
			
			case WeaponType.Club:
				Debug.Log(WeaponObjects[1].name);
				Debug.Log(WeaponObjects[1].DoDamage());
				break;
			
			case WeaponType.Sword:
				Debug.Log(WeaponObjects[2].name);
				Debug.Log(WeaponObjects[2].DoDamage());
				break;
			
			case WeaponType.Spear:
				Debug.Log(WeaponObjects[3].name);
				Debug.Log(WeaponObjects[3].DoDamage());
				break;
			
			case WeaponType.Scimitar:
				Debug.Log(WeaponObjects[4].name);
				Debug.Log(WeaponObjects[4].DoDamage());
				break;
		}
	}
}
