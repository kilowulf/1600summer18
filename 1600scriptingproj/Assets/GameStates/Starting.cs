using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Starting : GameStateBase {

    // run call is overrided for repurposing
	public override void Run()
    {
        Debug.Log("Starting");
    }
}
