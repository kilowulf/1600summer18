using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMoveBehavior : MonoBehaviour {

    public float Speed = 2.20f;
    public int Direction;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Speed, Speed, Speed);
        transform.Translate(Speed, 0, 0);
    }
}
