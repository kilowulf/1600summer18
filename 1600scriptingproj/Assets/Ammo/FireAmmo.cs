using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour {

    
    //declare GameObject Ammo;
    public GameObject Ammo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Instantiate(Ammo);
            Instantiate(Ammo, transform.position, Quaternion.identity);           
            
            
        }
        
    }
}
