using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameStateBase : ScriptableObject, IGameState
{

    // virtual keyword allows function to be used as a template
    // and swap out with other operations; works in conjunction 
    // with keyword override
    public virtual void Run()
    {
        Debug.Log("Running");
    }
}

// interface sets up requirements for scripts
public interface IGameState
{
    void Run();
    
}