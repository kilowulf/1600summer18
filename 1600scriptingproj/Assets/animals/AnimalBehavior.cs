<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour {

    public Animal AnimalInfo;
    

	
    // coliision results in health update
    //private void OnTriggerEnter()
    //{
        // health increase on collision
        //AnimalInfo.UpdateHealth();
        //Debug.Log(AnimalInfo.Health);

        // health damage on collision
        //AnimalInfo.DamageToHealth();
        //Debug.Log(AnimalInfo.Health);
  //}

    


}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour {

    public Animal AnimalInfo;

    void Start()
    {
        print(AnimalInfo.Health);
    }

    // health update on collision
    private void OnTriggerEnter()
    {
        AnimalInfo.UpdateHealth();
    }





}
>>>>>>> master
