using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour {

    public Image HealthImage;
    public float HealthLevel = 1.0f;

	// Use this for initialization
	void Start () {
        // sets health image at start
        HealthImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        HealthImage.fillAmount = HealthLevel;
	}
}
