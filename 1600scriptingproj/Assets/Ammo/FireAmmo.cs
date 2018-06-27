using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour {

    // instantiates object ammo
    //public GameObject Ammo;
    public List<GameObject> Ammo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // count method gives length of 
            for (int i = 0; i < Ammo.Count; i++)
            {
                Ammo[i].SetActive(true);
            }
            
            //Instantiate(Ammo);
        }
        
    }
}
