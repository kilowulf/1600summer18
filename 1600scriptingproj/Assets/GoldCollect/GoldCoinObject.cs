using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GoldCoinObject : ScriptableObject {
	

	
	public WarriorClassBase AnywWarrior;

	//Range sets low to high permitted parameter
	[Range(0, 10)] public int GoldAmount = 1;

	public void GoldBagCollect()
	{
		// any animal can be updated
		AnywWarrior.GoldCoins += GoldAmount;
	}

	//onEnable runs when powerbase is enabled
	private void OnEnable()
	{
		Debug.Log("Gold Collected");
	}
}
