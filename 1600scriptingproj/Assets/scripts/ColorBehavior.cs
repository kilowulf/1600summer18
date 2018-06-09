using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehavior : MonoBehaviour {

    public ChangeUiColor ChangeColor;

	// Use this for initialization
	void Start () {
        ChangeColor.ColorUI(getComponent<Image>());
	}
	
	
}
