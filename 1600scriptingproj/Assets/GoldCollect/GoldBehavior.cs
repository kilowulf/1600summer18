using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBehavior : MonoBehaviour {

	public GoldCoinObject GoldCollect;

	private void OnTriggerEnter()
	{
		// runs power up method before de-activating
		GoldCollect.GoldBagCollect();

		// mono methods to switch off a object; make disappear
		// gameObject self reference to the powerup object
		gameObject.SetActive(false);
	}
}
