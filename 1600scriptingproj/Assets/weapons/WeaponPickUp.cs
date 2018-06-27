using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{

	public WeaponObject Weapon;
	public WeaponsCollection Collection;

	// ontriggerEnter enables a collection on collision
	private void OnTriggerEnter(Collider obj)
	{
		// call to collection list
		Collection.CollectWeapon(Weapon);
	}
}
