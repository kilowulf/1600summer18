using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerTrigger : MonoBehaviour {


    // dependency created between playerTrig and HealthBeh
    public FloatData HealthLevel;
    public FloatData EvilPower;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {

        if (HealthLevel.Value > 0)
        {
            HealthLevel.Value -= EvilPower.Value;
        }               
	}

    // Temp for dev
    private void OnDisable()
    {
        HealthLevel.Value = 1;
    }
}
