﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorBehavior : MonoBehaviour {

    public ChangeUiColor ChangeColor;

	// Use this for initialization
	void Start () {
        ChangeColor.ColorUI(GetComponent<Image>());
	}
	
	
}