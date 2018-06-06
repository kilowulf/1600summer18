using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class DoAddition : ScriptableObject{

    public int c;

    private void OnEnable()
    {
        c = Run(10, 2);
    }

    // functions can run return data; declare datatype
	public int Run(int a, int b)
    {
        return a += b;
    }
}
