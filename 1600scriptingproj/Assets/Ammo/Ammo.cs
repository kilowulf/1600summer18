using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {


    //private = lower, public = upper case
    private Rigidbody projectile;
    public FloatData ProjectileSpeed;
    public FloatData ProjectileUpgrade;
    public float Time = 0.5f;




	// Use this for initialization
	private void OnEnable () {

        projectile = GetComponent<Rigidbody>();
        //method Addforce (x, y, z)creates velocity for an object
        projectile.AddForce(0, 0, ProjectileSpeed.Value);

        Invoke("AddGravity", Time);
		// invoke will call deactivate object in 2 seconds
		Invoke("Deactivate", 3);		
	}

    private void AddGravity()
    {
        projectile.AddForce(0, -ProjectileSpeed.Value, 0);
    }
	
	// turns object off rather than destroy
	private void Deactivate()
	{
		Destroy(gameObject);
	}

    // on collision, speed is upgraded
    /*private void OnTriggerEnter(Collider other)
    {
        // upgrades ammo object
        ProjectileSpeed = ProjectileUpgrade;
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
    }
    */

}
