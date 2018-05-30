using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()] // scriptable objects are not behaviors
public class Mammal : Animal {

    public int HairCount = 1000;
    // Color is a unity class
    public Color HairColor; //assign syntax -Color.black;

}
