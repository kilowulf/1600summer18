using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMoveBehavior : MonoBehaviour {

    public float Xspeed = 2.20f;
    public float Yspeed = 2.20f;
    public float Zspeed = 2.20f;
    public float Vspeed = 2.20f;
    public int Direction;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xspeed, Yspeed, Zspeed);
        transform.Translate(Vspeed, 0, 0);
    }
}
