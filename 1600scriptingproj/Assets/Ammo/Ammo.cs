using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {


    //private = lower, public = upper case
    private Rigidbody projectile;
    public FloatData ProjectileSpeed;
    public FloatData ProjectileUpgrade;




	// Use this for initialization
	private void Start () {

        projectile = GetComponent<Rigidbody>();
        // addforce (x, y, z)
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
	}

    private void OnTriggerEnter(Collider other)
    {
        // upgrades ammo object
        ProjectileSpeed = ProjectileUpgrade;
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
    }


}
