using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*monobehavior is a parent class, from which animal inherits 
 
     */
public class animal : MonoBehaviour {

    public float Speed;
    public int PowerLevel;
    public string PlayerName;
    
    

	// Use this for initialization
	void Start () {
        //transform.Rotate(Speed, Speed, Speed);
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Rotate(Speed, Speed, Speed);
        transform.Translate(Speed, 0, 0);
        //transform.Rotate(Random(int),Random(int), Random(int);
    }
}
