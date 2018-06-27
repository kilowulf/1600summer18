using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {


    //private = lower, public = upper case
    private Rigidbody projectile;
    public FloatData ProjectileSpeed;
    public FloatData ProjectileUpgrade;




	// Use this for initialization
	private void OnEnable () {

        projectile = GetComponent<Rigidbody>();
        //method Addforce (x, y, z)creates velocity for an object
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
		// invoke will call destroyobject in 2 seconds
		Invoke("DestroyObject", 2);

		
	}
	
	// turns object off rather than destroy
	private void DestroyObject()
	{
		gameObject.SetActive(false);
	}

    // on collision, speed is upgraded
    private void OnTriggerEnter(Collider other)
    {
        // upgrades ammo object
        ProjectileSpeed = ProjectileUpgrade;
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
    }


}
