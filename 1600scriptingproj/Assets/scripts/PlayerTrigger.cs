using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerTrigger : MonoBehaviour {

    public FloatData HealthLevel;
    // dependency created between playerTrig and HealthBeh
    
    public FloatData EvilPower;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
        HealthLevel.Value -= EvilPower.Value;        
	}
}
