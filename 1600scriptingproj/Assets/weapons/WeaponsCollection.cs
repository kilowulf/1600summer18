
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponsCollection : ScriptableObject
{

	public List<WeaponObject> Weapons;

	 // void-does not return data
	public void CollectWeapon(WeaponObject weapon)
	{
		Debug.Log(weapon);
		// adds weapon to collection object
		Weapons.Add(weapon);
 
		// iterates and consoles each item in weapon list
		foreach (var item in Weapons)
		{
			Debug.Log(item);

            // consoles message when in contact with sword object
            if (item.name == "Sword") ;
			{
				Debug.Log("You have the best sword!");
			}
		}
	}
	
}
