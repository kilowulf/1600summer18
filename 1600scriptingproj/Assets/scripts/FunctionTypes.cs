using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTypes : MonoBehaviour {


    // void functions do  not return anything
	void NoReturnType()
    {
        // Do work;
    }

    void VoidWithParams(string s, string t)
    {
        // Do work with s or t;
    }

    // numerical values with a function
    int NameOfFunction()
    {
        return 0;
    }

    // creating and using game objects
    GameObject ReturnGameObject()
    {
        return new GameObject();
    }

    // alternative use/ creation of gameobject in function
    GameObject ReturnGameObject2(GameObject obj)
    {
        return obj;
    }

    // coderoutines allow for breaks or interrupts within code
    IEnumerator CoroutineName()
    {
        // Do Work
        yield return new WaitForSeconds(1);
        // Do more work
    }




}
