using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehavior : MonoBehaviour {

    public Zombie ZombieInfo;

        

    void OnTriggerEnter()
    {
        // calls method from zombie class
        ZombieInfo.DamageToHealth();
        ZombieInfo.UpdateHealth();
        print("Bite");
        print(ZombieInfo.Health);
    }
}
