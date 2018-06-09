<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour {

    public float HealthLevel = 1.0f;
    public Image HealthImage;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    // add acces to fillAmount
	void Update () {
        HealthImage.fillAmount = HealthLevel;
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour {

    public FloatData HealthImage;
    public  FloatData HealthLevel;
    //public Image HealthImage;
    
	// Use this for initialization
	void Start () {
        // sets health image at start
        //HealthImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        HealthImage.fillAmount = HealthLevel.Value;
	}
}
>>>>>>> master
