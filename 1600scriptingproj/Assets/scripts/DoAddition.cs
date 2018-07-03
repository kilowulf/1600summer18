using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class DoAddition : ScriptableObject
{


    public int c;

    public int Run(int a, int b)
    {
        return a += b;
    }

    private void OnEnable()
    {
        //c = Run(10, 2);
    }

}


